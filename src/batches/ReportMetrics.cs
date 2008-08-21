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

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
