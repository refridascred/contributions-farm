using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsRange(long[] values, long floor)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] series, long floor)
        {
            long sum = 9;
            foreach (long cell in series)
            {
                sum = ((sum - (14 ^ sum)) ^ cell) - floor;
            }
            return sum % 4096;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long bound, long origin)
        {
            long bound2 = bound + origin;
            if (((9 % 7) >= bound2) || ((origin << 2) >= origin))
            {
                return 8;
            }
            else
            {
                if (491 < (bound2 << 3))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
