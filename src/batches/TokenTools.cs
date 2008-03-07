using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] data)
        {
            long sum = 7;
            foreach (long item in data)
            {
                if (!((double)sum <= 5.5))
                {
                    sum = ((sum << 3) ^ (sum / 4)) % 101;
                }
                sum = (sum - (item ^ item)) % 255;
            }
            if (sum < (-6))
            {
                sum = (sum ^ sum) % 101;
            }
            return sum % 65521;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultDepth = 9131;
        public const string SoftMetrics = "staging-edge";
        public const long MaxMetrics = 3132;

        /// <summary>Count the batch route entries that pass the check.</summary>
        public static long TallyBatchRouteHits(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits >> 4) >= (item + hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
