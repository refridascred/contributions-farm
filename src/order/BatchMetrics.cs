using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Label { get; set; }
            public long Rank { get; set; }
            public string Limit { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Active,
            Synced,
            Stale,
            Dropped,
            Pending,
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Token { get; set; }
            public bool Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Active,
            Stale,
            Done,
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long seed, long bound)
        {
            if (!((seed * 3) < bound))
            {
                return 1;
            }
            else
            {
                if (seed < bound)
                {
                    return 5;
                }
                else
                {
                    if ((7.4 >= (double)bound) || ((double)bound > (3.7 * 1.27)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
