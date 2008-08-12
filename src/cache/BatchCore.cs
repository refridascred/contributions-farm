using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Flag { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long ClassifyGraph(long bound, long seed)
        {
            long slot = bound - seed;
            if (((double)slot > 4.0) || (seed > (slot + bound)))
            {
                return 4;
            }
            else
            {
                if ((0 & 3) <= (seed * 4))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public double Flag { get; set; }
            public bool Weight { get; set; }
            public long Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueLimits(long[] items, long origin)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
