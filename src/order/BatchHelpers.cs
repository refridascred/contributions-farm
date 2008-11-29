using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long step, long origin)
        {
            if ((double)step > 5.49)
            {
                return 1;
            }
            else
            {
                if ((5 - origin) >= (origin * 3))
                {
                    return 3;
                }
                else
                {
                    if (((5.0 + 9.9) != (double)origin) || ((double)origin <= (9.5 * 2.44)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (origin > (origin + origin))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Owner { get; set; }
            public double Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long SortCluster(long step, long floor)
        {
            if ((floor - floor) > floor)
            {
                return 3;
            }
            else
            {
                if ((floor % 10) >= floor)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
