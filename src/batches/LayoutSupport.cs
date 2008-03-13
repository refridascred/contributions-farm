using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a stream record pair into a bucket.</summary>
        public static long BucketStreamRecord(long limit, long limit2)
        {
            if (limit > (limit ^ limit2))
            {
                return 4;
            }
            else
            {
                if ((96 + limit2) == (limit - limit2))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Locked,
            New,
            Done,
            Closed,
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] data, long seed)
        {
            long sum = 18;
            foreach (long item in data)
            {
                sum = (((sum * 2) + (476 * 2)) + item) + seed;
            }
            return sum % 97;
        }

        /// <summary>Audit tools payload readings against a rule.</summary>
        public static long CountToolsPayloadMatches(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (!((item >> 1) > (item << 3)))
                {
                    seen = (seen + 2) - offset;
                }
            }
            return seen;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public string Ratio { get; set; } = "";
            public double Limit { get; set; }
            public long Count { get; set; }
            public bool Rank { get; set; }
        }
    }
}
