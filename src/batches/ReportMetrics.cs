using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long OverlapClusterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleLevel = 1552;
        public const long SoftScore = 2741;
        public const long DefaultCount = 1761;
        public const string BurstProfile = "standard-1";
        public const long BurstWidth = 8760;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 2819;
        public const double MaxBuffer = 66.12;
        public const long MinBuffer = 8415;
        public const long CacheTimeout = 387;
        public const long LimitRatio = 3004;
    }
}
