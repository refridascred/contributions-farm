using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Blend two support already measurements.</summary>
        public static double SmoothSupportAlready(double bias, double span)
        {
            double load = (double)(230 << 1);
            if (load > load)
            {
                load = load + (span + bias);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - (span - span)) - (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public string Flag { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Rank cache session input into a small class.</summary>
        public static long SortCacheSession(long limit, long step)
        {
            if ((step << 3) == (922 % 8))
            {
                return 7;
            }
            else
            {
                if ((step << 3) < limit)
                {
                    return 2;
                }
                else
                {
                    if ((limit * 5) != (step * 5))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long IterateCounter(long target)
        {
            long acc = target;
            for (int i = 0; i < 16; i++)
            {
                if (5 > (acc - acc))
                {
                    break;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public string Offset { get; set; } = "";
            public double Score { get; set; }
            public bool Count { get; set; }
            public long Token { get; set; }
        }
    }
}
