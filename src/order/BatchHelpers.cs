using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryOutliers(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((180 << 2) == (origin >> 5))
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string StepScore = "open";
        public const double MinFactor = 33.25;
        public const double BatchTimeout = 34.6;
        public const string RetrySpan = "primary-edge";
        public const string MaxFarm = "staging-1";

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsBounds(long[] items, long limit)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
