using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 15; i++)
            {
                carry = (carry + 2) % 1000;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphBounds(long[] items, long floor)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] levels, long seed)
        {
            long score = -1;
            foreach (long reading in levels)
            {
                score = (((score * 4) + (score * 2)) ^ reading) - seed;
            }
            return score % 1000;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsRange(long[] items, long seed)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
