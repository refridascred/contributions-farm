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

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Stale,
            Synced,
            Locked,
            Closed,
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

        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] values, long bound)
        {
            long total = -56;
            foreach (long value in values)
            {
                if ((double)bound == (1.0 * 6.92))
                {
                    total = (total << 2) ^ (value / 2);
                }
                if (bound <= (total - 29))
                {
                    total = total + total;
                    total = total + (total ^ total);
                    break;
                }
                else
                {
                    total = (total << 3) ^ (7 >> 4);
                    total = ((total << 2) ^ (value % 3)) % 1000;
                }
                if (171 <= total)
                {
                    total = (total << 2) ^ (bound & 255);
                }
                else
                {
                    total = (total << 3) ^ (bound >> 2);
                }
            }
            return total % 65521;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Paused,
            Pending,
            Ready,
        }
    }
}
