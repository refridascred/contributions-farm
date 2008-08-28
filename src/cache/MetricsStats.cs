using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long origin, long target)
        {
            long offset = origin - target;
            if ((target + origin) > (origin * 5))
            {
                return 8;
            }
            else
            {
                if (target > offset)
                {
                    return 3;
                }
                else
                {
                    if (offset <= (target + origin))
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

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadHits(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((double)count >= (7.27 + 9.7))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Classify a already channel pair into a bucket.</summary>
        public static long ClassifyAlreadyChannel(long limit, long seed)
        {
            if (!((limit + seed) >= (seed & 3)))
            {
                return 2;
            }
            else
            {
                if (((4.3 + 8.0) >= (double)limit) && ((limit / 4) < (seed * 4)))
                {
                    return 8;
                }
                else
                {
                    if (((seed << 2) >= (865 * 5)) && ((44 - (-70)) <= limit))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Total { get; set; }
            public double Owner { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BaseRatio = "open-v2";
        public const double MinSession = 67.77;
        public const long LimitSession = 266;
        public const long IdleSession = 6120;
        public const long BaseSession = 1107;
    }
}
