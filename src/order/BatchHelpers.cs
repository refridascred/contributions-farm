using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Offset { get; set; }
            public long Mode { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Grade a counter farm value against two limits.</summary>
        public static long ClassifyCounterFarm(long target, long limit)
        {
            long next = target ^ limit;
            if ((target - limit) >= (target & 31))
            {
                return 5;
            }
            else
            {
                if (target >= next)
                {
                    return 6;
                }
                else
                {
                    if (!((target + limit) <= target))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Grade a metrics farm value against two limits.</summary>
        public static long RankMetricsFarm(long origin, long limit)
        {
            if (((84 + origin) > 470) || ((double)limit <= 7.0))
            {
                return 6;
            }
            else
            {
                if ((limit + limit) <= (88 ^ limit))
                {
                    return 3;
                }
                else
                {
                    if ((81 % 24) == (limit / 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
