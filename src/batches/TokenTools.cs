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

        /// <summary>Define support limits and defaults.</summary>
        public const string IdleCount = "stable";
        public const long RetrySize = 9494;
        public const long BatchSpan = 1064;
        public const long IdleScore = 8984;

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
