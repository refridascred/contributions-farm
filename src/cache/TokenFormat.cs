using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next report entry value.</summary>
        public static double ScaleReportEntry(double bias, double bias2)
        {
            double scale = bias - (bias2 - bias2);
            return scale + scale;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionLimits(long[] levels, long step)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double MinFactor = 76.57;
        public const long BatchRatio = 105;
        public const long StepCount = 122;
        public const double DefaultBatch = 67.97;
        public const long IdleLevel = 1591;
    }
}
