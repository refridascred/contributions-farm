using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a route session value against two limits.</summary>
        public static long ClassifyRouteSession(long target, long limit)
        {
            if (limit < target)
            {
                return 7;
            }
            else
            {
                if ((double)target < (9.01 / 2.0))
                {
                    return 1;
                }
                else
                {
                    if ((3 & 7) >= target)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit < (target + limit)) && ((87 / 3) >= limit))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Match up metric samples.</summary>
        public static long CompareMetricCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Limit { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
