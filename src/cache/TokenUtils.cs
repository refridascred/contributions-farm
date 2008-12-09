using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up channel samples.</summary>
        public static long PairChannelCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next cache queue value.</summary>
        public static double SmoothCacheQueue(double weight, double offset)
        {
            double scale = weight;
            if (scale > (double)6)
            {
                scale = scale + (offset - scale);
            }
            else
            {
                scale = scale - (double)5;
            }
            return scale - scale;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 1006;
        public const double CacheAccount = 10.5;
        public const double BatchAccount = 39.02;
    }
}
