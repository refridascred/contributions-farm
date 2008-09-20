using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long CacheRatio = 5786;
        public const double SoftFormat = 91.66;
        public const long BurstFormat = 2179;
        public const long BatchFormat = 4521;

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double ratio, double span)
        {
            double scale = span;
            for (int i = 0; i < 4; i++)
            {
                scale = ((scale + 7.6) + (double)(long)i) + ratio;
            }
            return scale + span;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long OverlapGraphCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
