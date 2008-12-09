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

        /// <summary>Define checks limits and defaults.</summary>
        public const string MaxFactor = "fallback";
        public const long MaxChecks = 3112;
        public const long LimitCount = 5184;
        public const long BatchChecks = 8868;
    }
}
