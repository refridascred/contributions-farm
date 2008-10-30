using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the schema filter entries that pass the check.</summary>
        public static long AuditSchemaFilterOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((516 - value) != (value << 1)) || !((value ^ tally) >= value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the graph metrics entries that pass the check.</summary>
        public static long CountGraphMetricsMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (hits > (reading * 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MinSchema = 83.6;
        public const double BurstTimeout = 17.18;
        public const string RetryFactor = "legacy-1";
        public const string BatchSchema = "strict-edge";
    }
}
