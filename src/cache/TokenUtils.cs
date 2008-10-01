using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long bound, long step)
        {
            long diff = bound ^ step;
            if ((double)step >= (6.0 - 1.0))
            {
                return 8;
            }
            else
            {
                if (diff < bound)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitBudget = 1925;
        public const string MinBudget = "local-v2";
        public const long WindowContext = 294;
        public const long BatchSize = 3285;

        /// <summary>Match up batch samples.</summary>
        public static long CompareBatchCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
