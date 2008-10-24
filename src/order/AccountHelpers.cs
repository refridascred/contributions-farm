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

        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > limit) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
