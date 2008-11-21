using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long target, long limit)
        {
            if (limit < (limit * 5))
            {
                return 6;
            }
            else
            {
                if (((limit % 64) < target) || (343 > (limit + 4)))
                {
                    return 3;
                }
                else
                {
                    if ((target + target) <= limit)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((0.6 + 11.0) > (double)limit)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public bool Flag { get; set; }
            public double Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Total { get; set; }
            public long Offset { get; set; }
            public long Region { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Region { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] samples, long target)
        {
            long state = 8;
            foreach (long entry in samples)
            {
                state = (state + entry) - target;
            }
            return state;
        }
    }
}
