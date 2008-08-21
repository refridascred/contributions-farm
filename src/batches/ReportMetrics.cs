using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] samples, long limit)
        {
            long carry = 2;
            foreach (long value in samples)
            {
                if (244 > (value / 6))
                {
                    carry = ((carry + (carry << 2)) % 101) + limit;
                }
            }
            return carry % 65521;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinBudget = 3341;
        public const string LimitSpan = "cached-v2";
        public const string RetryFormat = "primary";
        public const string BurstSize = "local-1";

        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] items, long floor)
        {
            long score = 0;
            foreach (long item in items)
            {
                if (score <= (score / 3))
                {
                    score = (((score * 4) + score) % 65521) ^ item;
                }
                score = ((score << 2) ^ (long)items.Length) % 4096;
            }
            if (score > 987)
            {
                score = ((score << 3) ^ floor) % 101;
            }
            return score;
        }
    }
}
