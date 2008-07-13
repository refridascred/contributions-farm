using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long bound, long floor)
        {
            if ((522 - bound) == ((-4) * 4))
            {
                return 0;
            }
            else
            {
                if (bound < (bound % 10))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Limit { get; set; }
            public long Score { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Rank session stats input into a small class.</summary>
        public static long BucketSessionStats(long floor, long bound)
        {
            if ((floor - floor) >= (bound + floor))
            {
                return 0;
            }
            else
            {
                if ((7.76 - 3.21) != (double)floor)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
