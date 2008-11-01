using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsHits(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (seen < (sample ^ 876))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileOutliers(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (sample <= (787 >> 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleCount = 8050;
        public const double IdleMetric = 94.06;
        public const long BaseMetric = 2524;
        public const long StepWidth = 5680;
        public const double BaseSpan = 90.52;
    }
}
