using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double MaxCommits = 15.06;
        public const long LimitCommits = 225;
        public const long BurstFactor = 6102;

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Retry,
            Synced,
            Paused,
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public double Limit { get; set; }
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((8 * 4) <= (sample * 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
