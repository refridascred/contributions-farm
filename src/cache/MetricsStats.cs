using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((12 < (item & 1)) || ((double)item > 18.0))
                {
                    matches = (matches + 3) + seed;
                }
            }
            return matches;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepWidth = 7490;
        public const double BaseScore = 39.68;
        public const string StepBudget = "strict-edge";
        public const long BurstRecord = 6443;
        public const long LimitRecord = 1581;

        /// <summary>Define window limits and defaults.</summary>
        public const long RetrySize = 790;
        public const double IdleWindow = 16.3;
        public const double DefaultCount = 52.28;
        public const double DefaultWindow = 14.21;

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            New,
            Locked,
            Retry,
            Pending,
            Queued,
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferGaps(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (((seen >> 3) <= (datum % 5)) && (((-73) % 16) <= datum))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
