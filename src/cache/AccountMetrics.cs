using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Pending,
            Ready,
            Queued,
            Closed,
            Synced,
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Retry,
            Stale,
            Queued,
            Synced,
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Ready,
            Retry,
            Done,
        }

        /// <summary>Fold a list of cache record readings.</summary>
        public static long CombineCacheRecord(long[] values)
        {
            long state = 8;
            foreach (long cell in values)
            {
                if ((double)state < (3.4 + 7.27))
                {
                    state = (state ^ state) % 101;
                }
                else
                {
                    state = (state ^ (state + cell)) % 255;
                }
            }
            return state;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string SoftScore = "fallback";
        public const long IdleScore = 8271;
        public const double SoftContributi = 13.93;

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportGaps(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((2.22 * 10.0) <= (double)sample)
                {
                    seen = (seen + 2) - floor;
                }
            }
            return seen;
        }
    }
}
