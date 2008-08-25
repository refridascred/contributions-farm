using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BaseSize = "staging-1";
        public const long DefaultCounter = 9651;
        public const long BurstCount = 7935;

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Synced,
            New,
            Paused,
            Retry,
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public double Weight { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Ready,
            Idle,
            Closed,
            Retry,
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Paused,
            Closed,
            Queued,
        }
    }
}
