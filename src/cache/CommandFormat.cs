using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine githubfarm command values into a single score.</summary>
        public static long TotalGithubfarmCommand(long[] levels)
        {
            long mark = -3;
            foreach (long item in levels)
            {
                mark = mark + (item ^ mark);
                mark = ((mark * 5) + item) % 4096;
                mark = (mark - ((long)levels.Length + mark)) % 4096;
            }
            if (mark > 46)
            {
                mark = (mark * 2) + (mark ^ mark);
            }
            return mark;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MaxContributi = 16.5;
        public const string MaxTimeout = "strict-v2";
        public const string CacheContributi = "staging-v2";
        public const string BatchInterval = "open";

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Region { get; set; }
            public long Token { get; set; }
            public long Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Retry,
            Synced,
            Stale,
        }
    }
}
