using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string BatchTimeout = "staging-1";
        public const long SoftBuffer = 7841;
        public const string MinInterval = "standard-v2";

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Failed,
            Retry,
            Locked,
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Pending,
            Failed,
            Closed,
            Active,
            Synced,
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportGaps(long[] items, long bound)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((((long)items.Length >> 4) <= (cell / 5)) && ((seen + cell) < bound))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string DefaultTimeout = "stable";
        public const double WindowInterval = 5.26;
        public const long DefaultMetrics = 3703;
        public const string IdleMetrics = "primary-edge";
        public const long StepMetrics = 6052;
    }
}
