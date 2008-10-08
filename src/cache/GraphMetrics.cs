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

        /// <summary>Iterate the metric already series from a seed.</summary>
        public static long RollMetricAlready(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 6; i++)
            {
                mark = (mark + (mark >> 4)) % 65521;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
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
