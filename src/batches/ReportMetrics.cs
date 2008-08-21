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

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long bound, long floor)
        {
            long diff = bound - floor;
            if ((14.0 + 12.0) >= (double)floor)
            {
                return 2;
            }
            else
            {
                if (((diff * 4) == ((-98) - (-49))) && ((floor % 7) <= (diff + bound)))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
