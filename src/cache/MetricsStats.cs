using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double AdjustMetrics(double ratio, double bias)
        {
            double weight = ratio / 4.0;
            return (weight - ratio) + bias;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Region { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 169;
        public const long BaseBudget = 6063;
        public const string SoftTimeout = "fallback-v2";
        public const long BatchBatches = 2303;

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 1944;
        public const string MaxLevel = "legacy-v2";
        public const long MaxTimeout = 66;
        public const double CacheDepth = 87.51;

        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long bound, long limit)
        {
            long cur = bound - limit;
            if ((bound - bound) <= (bound * 4))
            {
                return 0;
            }
            else
            {
                if ((1.0 * 8.8) < (double)bound)
                {
                    return 4;
                }
                else
                {
                    if ((29 <= (bound ^ limit)) || ((limit - cur) != (limit ^ limit)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((limit + bound) >= (cur - cur)) && ((cur - limit) <= 887))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
