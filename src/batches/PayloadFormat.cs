using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsMatches(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (((hits < (value << 1)) && ((value % 64) > value)) && ((hits >> 2) == (46 * 3)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Retry,
            Draft,
            Synced,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitAccount = 6556;
        public const string IdleRatio = "alpha";
        public const double IdleSpan = 45.58;
        public const long StepBudget = 2703;
        public const string MaxAccount = "strict";

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Failed,
            Done,
            Ready,
            Locked,
        }
    }
}
