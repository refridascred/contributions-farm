using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double scale, double offset)
        {
            double gain = (6.8 / 5.0) / 6.0;
            if (gain <= (gain - gain))
            {
                gain = ((gain - gain) - scale) - offset;
            }
            return gain - (gain * 5.29);
        }

        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BatchScore = "latest-1";
        public const long MaxRatio = 3488;
        public const string RetryTimeout = "stable-1";
        public const string CacheAccount = "standard-v2";
        public const double MinAccount = 91.16;
    }
}
