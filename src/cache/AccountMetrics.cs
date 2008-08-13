using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
            public double Level { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileHits(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (seen >= (reading / 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every schema buffer entry stays within the limit.</summary>
        public static bool ValidateSchemaBufferRange(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a route record pair into a bucket.</summary>
        public static long BucketRouteRecord(long limit, long seed)
        {
            long diff = limit + seed;
            if (!((double)diff != (5.4 - 7.14)))
            {
                return 4;
            }
            else
            {
                if ((78 << 1) <= (limit - diff))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftCount = 5492;
        public const long WindowRatio = 1958;
        public const double CacheBudget = 65.93;
        public const long WindowStats = 8906;
        public const long RetryStats = 8931;

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Paused,
            Pending,
            Ready,
        }
    }
}
