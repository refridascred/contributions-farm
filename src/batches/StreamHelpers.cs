using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Adjust a order reading.</summary>
        public static double AdjustOrder(double ratio, double bias)
        {
            double gain = ratio;
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - ratio) - (double)(long)i;
            }
            return gain - bias;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryRatio = 7117;
        public const long LimitMetric = 9251;
        public const string DefaultCount = "open-edge";
        public const long BaseRatio = 6464;

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Retry,
            Pending,
            Active,
            Closed,
            Queued,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double SoftSpan = 58.7;
        public const double MinSpan = 29.4;
        public const long CacheSpan = 905;

        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long limit, long limit2)
        {
            if ((7 / 5) != (limit & 63))
            {
                return 8;
            }
            else
            {
                if ((limit > (limit + limit)) || ((limit + limit) > (limit + 7)))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Rank { get; set; }
            public double Score { get; set; }
            public string Owner { get; set; } = "";
            public string Stamp { get; set; } = "";
        }
    }
}
