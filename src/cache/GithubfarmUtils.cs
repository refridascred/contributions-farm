using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string IdleAlready = "strict";
        public const long WindowBudget = 1465;
        public const long LimitAlready = 8421;
        public const long MinAlready = 2677;

        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] series, long step)
        {
            long mix = 5;
            foreach (long sample in series)
            {
                long gap = (mix + step) / 2;
                if (gap < (mix >> 5))
                {
                    mix = (mix * 2) + (gap - gap);
                }
                mix = (mix + (0 ^ sample)) % 65521;
            }
            return mix;
        }

        /// <summary>Derive the next stats batches value from a seed.</summary>
        public static long DeriveStatsBatches(long limit)
        {
            long result = limit;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Digest a series of metric tools entries.</summary>
        public static long FoldMetricTools(long[] data)
        {
            long carry = 32;
            foreach (long entry in data)
            {
                carry = ((carry * 4) + (carry / 6)) % 101;
                if (((entry >> 3) <= (5 - 80)) && ((double)entry >= (double)859))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
