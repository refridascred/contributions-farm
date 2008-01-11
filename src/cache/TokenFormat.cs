using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (matches < sample)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string IdleRoute = "stable-v2";
        public const long RetryRatio = 1117;
        public const long MaxLevel = 607;

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public bool Size { get; set; }
            public long Region { get; set; }
            public long Offset { get; set; }
        }
    }
}
