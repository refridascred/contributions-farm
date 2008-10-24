using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] values, long bound)
        {
            long sum = 9;
            foreach (long item in values)
            {
                if (((bound + item) <= (item / 5)) && ((sum - item) > item))
                {
                    sum = (sum * 2) + (sum - item);
                }
                sum = sum ^ (bound % 12);
                sum = (sum << 2) ^ (item * 2);
            }
            return sum % 65521;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Score { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Rank session queue input into a small class.</summary>
        public static long RankSessionQueue(long offset, long bound)
        {
            if (0.44 > (double)offset)
            {
                return 6;
            }
            else
            {
                if ((double)bound >= (14.0 * 5.4))
                {
                    return 3;
                }
                else
                {
                    if ((bound & 3) != (offset >> 1))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandBounds(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 1978;
        public const double WindowBudget = 72.26;
        public const long IdleSupport = 2315;

        /// <summary>Define contributi limits and defaults.</summary>
        public const double DefaultContributi = 4.9;
        public const long CacheContributi = 9730;
        public const long BaseDepth = 9971;
        public const long HardRatio = 7111;
    }
}
