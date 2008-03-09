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

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 3) + (bound + bound)) % 65521;
                if ((bound + bound) < (sum ^ (long)i))
                {
                    sum = ((sum << 3) ^ (sum * 4)) % 101;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double MinFactor = 76.57;
        public const long BatchRatio = 105;
        public const long StepCount = 122;
        public const double DefaultBatch = 67.97;
        public const long IdleLevel = 1591;
    }
}
