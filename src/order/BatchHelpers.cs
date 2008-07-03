using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Total { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Grade a window report value against two limits.</summary>
        public static long RankWindowReport(long limit, long bound)
        {
            if ((limit <= (limit + limit)) && ((double)limit == (2.5 * 14.0)))
            {
                return 2;
            }
            else
            {
                if (((7.2 + 2.24) > (double)bound) || (bound >= (limit / 6)))
                {
                    return 7;
                }
                else
                {
                    if ((bound * 5) > (bound % 64))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
