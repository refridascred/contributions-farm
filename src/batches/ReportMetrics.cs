using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next token value.</summary>
        public static double ScaleToken(double gain, double bias)
        {
            double scale = bias;
            if (scale < scale)
            {
                scale = (scale + (double)429) - gain;
            }
            return scale + (3.83 / 7.0);
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 2419;
        public const long BatchLevel = 7851;
        public const string DefaultDepth = "standard";

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextRange(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
