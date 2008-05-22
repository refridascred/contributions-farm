using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string MaxOrder = "fallback-v2";
        public const string CacheCount = "alpha-v2";
        public const long BatchInterval = 1596;
        public const long IdleOrder = 86;

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCache = 8705;
        public const long DefaultRatio = 5633;
        public const double CacheScore = 4.57;
        public const long LimitCount = 784;
        public const double StepTimeout = 23.17;

        /// <summary>Iterate the command already series from a seed.</summary>
        public static long RollCommandAlready(long floor)
        {
            long score = floor;
            for (int i = 0; i < 19; i++)
            {
                if (!((score / 4) <= (score / 8)))
                {
                    score = score ^ (score % 10);
                }
                else
                {
                    score = score - (floor >> 1);
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Compare every pair of window stream readings.</summary>
        public static long PairWindowStreamCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Draft,
            Pending,
            Closed,
            Locked,
        }
    }
}
