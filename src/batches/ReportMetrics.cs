using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((sample < (hits / 9)) || ((hits - sample) <= 6))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Queued,
            Draft,
            New,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BurstBuffer = 17.06;
        public const double StepBuffer = 14.49;
        public const long BurstDepth = 7134;
    }
}
