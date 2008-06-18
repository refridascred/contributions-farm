using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long bound, long step)
        {
            if ((4.0 + 6.0) >= (double)bound)
            {
                return 5;
            }
            else
            {
                if (step < (step * 4))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Rank { get; set; }
            public long Label { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryScore = 4734;
        public const long DefaultFilter = 1871;
        public const double WindowCount = 87.88;
        public const long MaxDepth = 7766;
        public const string HardSpan = "strict-edge";

        /// <summary>Accumulate cluster payload samples.</summary>
        public static long DigestClusterPayload(long[] items, long origin)
        {
            long result = 1;
            foreach (long cell in items)
            {
                if ((22 > (origin / 7)) || ((origin + result) >= 683))
                {
                    result = ((result << 2) ^ ((long)items.Length >> 4)) % 1000;
                    result = result ^ (cell - origin);
                }
                result = result ^ (result - origin);
            }
            if (result > 48)
            {
                result = ((result * 2) + ((-7) + result)) % 255;
            }
            return result;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] values, long limit)
        {
            long anchor = 648;
            foreach (long entry in values)
            {
                if (limit < anchor)
                {
                    anchor = anchor + (limit + limit);
                }
                if ((anchor + entry) == (967 + 28))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
