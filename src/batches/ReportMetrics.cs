using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportGaps(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (tally >= reading)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSchema = 8606;
        public const long MinLevel = 6461;
        public const double CacheSchema = 56.63;

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Active,
            Closed,
            Dropped,
        }
    }
}
