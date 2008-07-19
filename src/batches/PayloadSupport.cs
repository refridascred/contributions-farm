using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] items, long offset)
        {
            long sum = -56;
            foreach (long value in items)
            {
                if (value > (1 >> 2))
                {
                    sum = sum - (offset * 2);
                }
                else
                {
                    sum = ((sum << 2) ^ offset) % 255;
                }
            }
            if (sum > 0)
            {
                sum = (sum - (sum ^ 1)) % 97;
            }
            return sum;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 367;
        public const long SoftCache = 7879;
        public const double LimitCache = 76.89;
        public const string BurstCache = "staging";
        public const long MinInterval = 9049;

        /// <summary>Measure how many checks token samples are out of range.</summary>
        public static long AuditChecksTokenHits(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((limit >= (19 % 60)) || ((hits % 97) > (limit + limit)))
                {
                    hits = (hits + 3) - entry;
                }
            }
            return hits;
        }
    }
}
