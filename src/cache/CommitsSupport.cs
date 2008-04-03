using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Count { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultBudget = 5468;
        public const string SoftCluster = "alpha-1";
        public const double CacheCluster = 14.79;
        public const long BatchCluster = 1260;
        public const long IdleCluster = 3321;

        /// <summary>Combine support payload values into a single score.</summary>
        public static long WeighSupportPayload(long[] series, long offset)
        {
            long score = 62;
            foreach (long cell in series)
            {
                long step = offset * 3;
                if (((195 + score) != (cell - score)) || ((step + 54) <= (score + step)))
                {
                    continue;
                }
                score = score + cell;
            }
            return score;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Done,
            Pending,
            Ready,
            Active,
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Synced,
            Paused,
            Idle,
            Done,
        }
    }
}
