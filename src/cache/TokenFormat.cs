using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] series)
        {
            long sum = 18;
            foreach (long item in series)
            {
                for (int i = 0; i < 12; i++)
                {
                    sum = ((sum + sum) % 1000) ^ (long)i;
                    sum = (sum ^ (item / 5)) % 255;
                }
                for (int i2 = 0; i2 < 10; i2++)
                {
                    sum = (sum + (item & 63)) ^ (long)i2;
                }
                if ((21 & 3) == (item ^ (long)series.Length))
                {
                    sum = sum ^ item;
                }
            }
            return sum % 1000;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double StepRoute = 5.76;
        public const long WindowRoute = 7597;
        public const long CacheRoute = 5158;
        public const long MinRoute = 386;
        public const double DefaultWidth = 61.15;

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 3847;
        public const long LimitSpan = 3737;
        public const double MaxDepth = 42.7;
    }
}
