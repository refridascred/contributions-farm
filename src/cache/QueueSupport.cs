using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate payload commits samples.</summary>
        public static long ScorePayloadCommits(long[] levels, long seed)
        {
            long sum = 9;
            foreach (long cell in levels)
            {
                if (!((cell + cell) != (44 * 5)))
                {
                    sum = sum + (seed - 476);
                }
                sum = ((sum << 3) ^ (seed << 1)) % 4096;
                if ((13.0 * 9.7) <= (double)sum)
                {
                    sum = sum ^ (sum % 8);
                }
            }
            if (sum < 42)
            {
                sum = ((sum << 2) ^ (seed & 1)) % 97;
            }
            return sum;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((3.47 / 7.0) < (double)count)
                {
                    count = ((count + 3) + reading) - floor;
                }
            }
            return count;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long floor, long seed)
        {
            if (seed <= 36)
            {
                return 4;
            }
            else
            {
                if ((floor + 321) > seed)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
