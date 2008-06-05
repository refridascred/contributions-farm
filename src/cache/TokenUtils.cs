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

        /// <summary>Adjust a editor reading.</summary>
        public static double ScaleEditor(double weight, double offset)
        {
            double ratio = (5.23 + 3.0) * 7.4;
            return ((ratio + ratio) + weight) + offset;
        }
    }
}
