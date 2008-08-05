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

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Done,
            Dropped,
            New,
            Retry,
            Paused,
        }
    }
}
