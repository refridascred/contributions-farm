using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double bias, double offset)
        {
            double gain = offset;
            for (int i = 0; i < 8; i++)
            {
                gain = ((gain + (offset - offset)) + (double)(long)i) - bias;
            }
            return gain + (offset - 0.1);
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string CacheMetrics = "primary-edge";
        public const double MinMetrics = 74.72;
        public const long MaxMetrics = 8317;
        public const long DefaultDepth = 799;

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitSupport = 1502;
        public const long BaseSupport = 2292;
        public const string BatchSupport = "stable-edge";
        public const long WindowFactor = 6998;
        public const long StepInterval = 65;
    }
}
