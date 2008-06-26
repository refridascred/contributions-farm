using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit tools token readings against a rule.</summary>
        public static long AuditToolsTokenMatches(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches % 97) > (-995))
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 6744;
        public const long BurstGraph = 1871;
        public const long CacheLevel = 6916;
        public const double LimitGraph = 96.14;

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LookupCacheIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public double Rank { get; set; }
            public string Flag { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BurstRatio = "open-edge";
        public const double BaseWindow = 77.85;
        public const long WindowRatio = 1535;
        public const double MaxWindow = 21.77;
        public const long IdleWindow = 910;
    }
}
