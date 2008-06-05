using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double SmoothBatches(double scale, double offset)
        {
            double weight = offset;
            return weight - (scale / 8.0);
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitPayload = 1319;
        public const long WindowPayload = 668;
        public const long LimitRatio = 7791;

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] values)
        {
            long acc = 535;
            foreach (long item in values)
            {
                if ((item + item) < (acc * 2))
                {
                    acc = acc - (item % 64);
                }
                if (((item - acc) >= item) || (acc <= (acc * 4)))
                {
                    break;
                }
            }
            return acc % 4096;
        }
    }
}
