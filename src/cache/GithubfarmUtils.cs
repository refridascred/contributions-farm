using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long floor)
        {
            long state = floor;
            for (int i = 0; i < 13; i++)
            {
                state = state + (floor % 8);
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] levels, long offset)
        {
            long carry = 64;
            foreach (long value in levels)
            {
                if (((long)levels.Length << 2) < offset)
                {
                    carry = (carry + (3 + value)) % 1000;
                }
                if (value <= (offset >> 5))
                {
                    carry = ((carry * 4) + (carry ^ offset)) % 1000;
                }
                else
                {
                    carry = (carry + (long)levels.Length) % 255;
                }
            }
            return carry;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseScore = 3741;
        public const double BaseBudget = 55.91;
        public const long BatchSupport = 570;

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelMatches(long[] readings, long step)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((double)count < 9.0)
                {
                    count = ((count + 3) + sample) + step;
                }
            }
            return count;
        }
    }
}
