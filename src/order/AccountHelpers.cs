using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Ready,
            New,
            Dropped,
            Idle,
            Paused,
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Synced,
            Done,
            Idle,
            Locked,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardFactor = 4025;
        public const long MaxStream = 5300;
        public const long BatchStream = 9036;

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public double Total { get; set; }
            public bool Level { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Audit githubfarm buffer readings against a rule.</summary>
        public static long AuditGithubfarmBufferMatches(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (!((double)hits >= (1.68 - 7.35)) || ((8.1 / 8.0) < (double)bound))
                {
                    hits = (hits + 1) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LocateFormatIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
