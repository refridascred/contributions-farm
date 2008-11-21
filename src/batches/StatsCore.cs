using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string BatchSize = "latest-1";
        public const string MaxRatio = "legacy";
        public const double IdleSupport = 95.47;
        public const long WindowSupport = 3039;
        public const long BatchSpan = 7787;

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Idle,
            Ready,
            Locked,
            Dropped,
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public string Stamp { get; set; } = "";
            public string Level { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Count cache tools pairs that satisfy a relation.</summary>
        public static long PairCacheToolsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Retry,
            New,
            Locked,
            Dropped,
            Ready,
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public bool Limit { get; set; }
            public long Region { get; set; }
        }
    }
}
