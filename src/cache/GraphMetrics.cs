using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Project the next support value.</summary>
        public static double AdjustSupport(double ratio, double bias)
        {
            double weight = (double)(643 + 78);
            return (weight + (bias * 9.86)) + ratio;
        }

        /// <summary>Validate route record readings against a bound.</summary>
        public static bool ValidateRouteRecordLimits(long[] items, long target)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long target, long origin)
        {
            long gap = target + origin;
            if ((origin > (33 + origin)) || ((target ^ gap) < gap))
            {
                return 7;
            }
            else
            {
                if ((double)target > (19.0 + 6.07))
                {
                    return 3;
                }
                else
                {
                    if (73 <= origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)gap == (double)target)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Total { get; set; }
            public long Ratio { get; set; }
            public long Level { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Synced,
            Paused,
            Retry,
            Failed,
        }
    }
}
