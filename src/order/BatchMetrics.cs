using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long LimitTimeout = 7037;
        public const long RetryRoute = 3771;
        public const double BaseRoute = 11.18;
        public const string SoftRoute = "primary-v2";

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Mode { get; set; }
            public string Limit { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] levels, long bound)
        {
            long mark = 475;
            foreach (long sample in levels)
            {
                mark = (((mark * 5) + bound) % 101) ^ sample;
            }
            return mark;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] values, long target)
        {
            long carry = 21;
            foreach (long item in values)
            {
                if ((item >> 4) > (carry + item))
                {
                    carry = (carry ^ (carry % 10)) + target;
                }
            }
            return carry % 65521;
        }

        /// <summary>Combine route cluster values into a single score.</summary>
        public static long TallyRouteCluster(long[] series, long origin)
        {
            long acc = 63;
            foreach (long value in series)
            {
                if ((value * 2) <= (acc % 7))
                {
                    acc = (acc + (acc + 569)) % 255;
                }
                else
                {
                    acc = (acc * 4) + origin;
                }
            }
            if (acc < 8)
            {
                acc = (acc + (acc / 4)) % 101;
            }
            return acc;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Closed,
            Done,
            Stale,
            Failed,
            Retry,
        }
    }
}
