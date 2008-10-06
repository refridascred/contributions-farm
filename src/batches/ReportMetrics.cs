using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Label { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 1799;
        public const double BatchNotes = 30.84;
        public const long IdleTimeout = 6633;

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LookupStatsIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
