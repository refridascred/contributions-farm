using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 588;
        public const long MinFormat = 2197;
        public const long MinScore = 1078;
        public const long LimitLevel = 2126;

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
