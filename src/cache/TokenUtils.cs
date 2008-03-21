using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double RetryTimeout = 89.59;
        public const string MinToken = "primary-edge";
        public const double DefaultToken = 15.78;
        public const long MaxToken = 1232;

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long origin)
        {
            long score = origin;
            for (int i = 0; i < 11; i++)
            {
                score = score - origin;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
