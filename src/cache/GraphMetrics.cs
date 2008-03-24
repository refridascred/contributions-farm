using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterGaps(long[] series, long bound)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((bound - item) <= 461)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 7560;
        public const long BurstProfile = 1670;
        public const string StepTimeout = "standard-v2";

        /// <summary>Measure how many route metric samples are out of range.</summary>
        public static long MeasureRouteMetricGaps(long[] values, long floor)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((705 ^ floor) > (entry - hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountLimits(long[] items, long step)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterRange(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
