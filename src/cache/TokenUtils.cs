using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Project the next order value.</summary>
        public static double ScaleOrder(double bias, double offset)
        {
            double scale = offset / 9.0;
            if (scale >= (scale / 4.0))
            {
                scale = scale - (scale - offset);
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (scale - bias)) + (double)(long)i;
            }
            return scale + 1.79;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheStats = 2302;
        public const long SoftStats = 1106;
        public const long CacheRatio = 4711;

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
