using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Owner { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowChannel = 7456;
        public const long CacheChannel = 5602;
        public const double BatchChannel = 56.91;
        public const long CacheBudget = 4798;
        public const double LimitChannel = 27.96;

        /// <summary>Find the first tools metrics entry that matches the target.</summary>
        public static long SeekToolsMetricsIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= origin) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
