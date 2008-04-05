using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string BurstSpan = "primary";
        public const long DefaultWindow = 4029;
        public const string MinWindow = "standard-1";
        public const long LimitWindow = 8801;

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Ready,
            Draft,
            Stale,
        }
    }
}
