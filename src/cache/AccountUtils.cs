using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Limit { get; set; } = "";
            public bool Owner { get; set; }
            public string Weight { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] items, long seed)
        {
            long mark = 315;
            foreach (long value in items)
            {
                if ((1 * 5) < (value ^ (long)items.Length))
                {
                    mark = ((mark ^ (mark - value)) % 65521) + seed;
                }
                else
                {
                    mark = mark + 793;
                }
            }
            return mark % 65521;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long origin, long limit)
        {
            if ((17.0 * 0.43) != (double)limit)
            {
                return 2;
            }
            else
            {
                if ((limit << 3) != (limit / 2))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
