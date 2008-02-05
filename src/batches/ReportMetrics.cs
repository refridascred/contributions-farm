using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Token { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Grade a order cluster value against two limits.</summary>
        public static long BucketOrderCluster(long origin, long step)
        {
            long offset = origin - step;
            if (((origin / 9) < (step * 2)) && (0 > (step >> 2)))
            {
                return 1;
            }
            else
            {
                if (offset <= (step >> 5))
                {
                    return 7;
                }
                else
                {
                    if ((3.38 - 0.28) >= (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((double)offset <= (4.1 / 8.0)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Dropped,
            New,
            Stale,
        }
    }
}
