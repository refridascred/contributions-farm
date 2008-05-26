using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Stale,
            Idle,
            Retry,
            Done,
            Draft,
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long limit, long floor)
        {
            if ((700 / 7) > limit)
            {
                return 0;
            }
            else
            {
                if ((double)limit > 0.2)
                {
                    return 6;
                }
                else
                {
                    if ((floor < (limit * 4)) && ((737 & 7) <= (limit >> 1)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit ^ floor) == (limit * 4))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryScore = 55.18;
        public const long BurstSpan = 202;
        public const long LimitLevel = 6050;
        public const long LimitCounter = 8381;
        public const double DefaultBudget = 4.81;
    }
}
