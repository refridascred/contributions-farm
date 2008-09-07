using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a checks profile counter forward.</summary>
        public static long StepChecksProfile(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long StepCommand(long offset)
        {
            long result = offset;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileGaps(long[] samples, long offset)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((offset + (-965)) <= (count - offset))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }
    }
}
