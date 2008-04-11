using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphLimits(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string CacheCount = "fallback-v2";
        public const long BaseTimeout = 2468;
        public const long BaseAccount = 908;
        public const double BurstWidth = 45.39;
        public const string MaxBudget = "staging-v2";

        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long bound, long target)
        {
            long lane = bound - target;
            if ((double)target >= (double)lane)
            {
                return 6;
            }
            else
            {
                if ((double)bound <= 9.0)
                {
                    return 4;
                }
                else
                {
                    if ((lane << 3) <= (lane % 100))
                    {
                        return 7;
                    }
                    else
                    {
                        if (target > (lane - bound))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
