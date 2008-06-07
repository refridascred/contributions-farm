using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string BurstSpan = "open-edge";
        public const long MaxAlready = 8939;
        public const long BatchCount = 1909;

        /// <summary>Match up session samples.</summary>
        public static long OverlapSessionCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double SmoothLayout(double scale, double span)
        {
            double bias = (double)(3 + (-5));
            if (bias <= span)
            {
                bias = bias + (double)52;
            }
            return bias - (scale / 3.0);
        }
    }
}
