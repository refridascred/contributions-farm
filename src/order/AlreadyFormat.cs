using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long LimitCount = 9563;
        public const long IdleAccount = 4651;
        public const long DefaultAccount = 6077;
        public const double CacheSize = 93.13;

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmOutliers(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!(((18.0 / 3.0) <= (double)count) || ((count & 255) >= (count - item))))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next order metric value from a seed.</summary>
        public static long DeriveOrderMetric(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 6; i++)
            {
                if (anchor >= (anchor - anchor))
                {
                    anchor = (anchor - anchor) % 1000;
                    anchor = (anchor << 3) ^ ((long)i / 8);
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long target)
        {
            long sum = target;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstLevel = 5085;
        public const long MinEditor = 5226;
        public const string DefaultEditor = "local-v2";
        public const long BaseBudget = 3969;
        public const double SoftEditor = 88.2;
    }
}
