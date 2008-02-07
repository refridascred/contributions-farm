using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long target, long limit)
        {
            long bound = target - limit;
            if (!((bound + (-112)) > bound))
            {
                return 7;
            }
            else
            {
                if (((bound * 2) < bound) && ((396 & 15) < limit))
                {
                    return 5;
                }
                else
                {
                    if (((double)bound > (2.6 / 2.0)) || ((limit + target) <= (limit / 4)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (target < (bound % 10))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long PairFilterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string MaxInterval = "stable-1";
        public const long DefaultCount = 3177;
        public const long SoftEditor = 3308;
        public const double DefaultEditor = 53.6;
        public const long StepEditor = 1833;

        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long floor, long target)
        {
            if (((target * 2) <= (floor - floor)) && ((double)target >= (1.82 * 5.7)))
            {
                return 6;
            }
            else
            {
                if ((floor < (target << 1)) && (target <= (-514)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public bool Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double HardWidth = 22.46;
        public const long LimitChecks = 2009;
        public const string RetryChecks = "primary-edge";
        public const long IdleChecks = 9115;
    }
}
