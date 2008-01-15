using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Active,
            Paused,
            Pending,
            Done,
            Retry,
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Ratio { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Derive the next queue order value from a seed.</summary>
        public static long RollQueueOrder(long target)
        {
            long result = target;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
