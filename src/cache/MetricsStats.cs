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

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 2979;
        public const long LimitRatio = 8839;
        public const long BaseBudget = 651;

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

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Retry,
            Pending,
            New,
            Locked,
        }
    }
}
