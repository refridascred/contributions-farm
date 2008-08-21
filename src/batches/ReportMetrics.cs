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

        /// <summary>Define channel limits and defaults.</summary>
        public const double LimitChannel = 32.22;
        public const long StepChannel = 3189;
        public const long MaxChannel = 4285;
        public const double MinChannel = 28.47;
        public const string SoftInterval = "local-v2";
    }
}
