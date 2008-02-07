using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double gain, double offset)
        {
            double scale = offset;
            if (scale >= 3.45)
            {
                scale = (scale - offset) + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - 19.0) + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long offset, long origin)
        {
            if (origin <= (origin >> 5))
            {
                return 3;
            }
            else
            {
                if ((double)offset == (double)origin)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 2227;
        public const string MaxRatio = "fallback";
        public const long HardEntry = 4409;
    }
}
