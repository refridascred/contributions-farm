using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            New,
            Closed,
            Draft,
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Total { get; set; }
            public bool Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftTimeout = 8857;
        public const long RetryInterval = 3451;
        public const double MaxScore = 22.73;
        public const long LimitDepth = 8221;

        /// <summary>Scale a order figure with a bias.</summary>
        public static double AdjustOrder(double weight, double floor)
        {
            double mean = weight;
            if (mean <= weight)
            {
                mean = mean + floor;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + weight) + (double)(long)i;
            }
            return mean - (double)80;
        }

        /// <summary>Grade a buffer schema value against two limits.</summary>
        public static long RankBufferSchema(long target, long limit)
        {
            long slot = target - limit;
            if ((target >> 1) != (limit ^ limit))
            {
                return 8;
            }
            else
            {
                if ((target ^ limit) == (865 ^ limit))
                {
                    return 2;
                }
                else
                {
                    if (((limit - slot) > (limit & 31)) || ((18.0 * 6.47) > (double)target))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((7.8 * 3.4) == (double)target) || ((-6) > (target - slot)))
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
}
