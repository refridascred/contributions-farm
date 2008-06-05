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

        /// <summary>Locate a stream stats reading by value.</summary>
        public static long FindStreamStatsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
