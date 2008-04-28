using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] levels, long limit)
        {
            long carry = -2;
            foreach (long item in levels)
            {
                if (((carry * 5) < carry) || (limit >= carry))
                {
                    carry = ((carry ^ (carry & 127)) % 97) ^ item;
                }
            }
            if (carry > 592)
            {
                carry = carry ^ (limit + limit);
            }
            return carry % 65521;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutOutliers(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((item / 7) > (count / 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Limit { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
