using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmBounds(long[] series, long target)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public double Level { get; set; }
            public string Limit { get; set; } = "";
            public long Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Combine farm checks values into a single score.</summary>
        public static long ScoreFarmChecks(long[] series, long origin)
        {
            long carry = 462;
            foreach (long value in series)
            {
                if ((2.0 - 11.0) <= (double)carry)
                {
                    carry = ((carry * 4) + (carry << 1)) ^ value;
                }
                if (carry > (origin / 8))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
