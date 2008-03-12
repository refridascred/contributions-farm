using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutRange(long[] values, long origin)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many metric batches samples are out of range.</summary>
        public static long AuditMetricBatchesMatches(long[] readings, long step)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (((count - count) <= (step << 1)) && ((reading + count) == (4 - reading)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleRatio = 4761;
        public const double LimitWidth = 70.45;
        public const long IdleCache = 2131;
        public const double BurstWidth = 13.28;
    }
}
