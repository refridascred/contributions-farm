using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two filter measurements.</summary>
        public static double ProjectFilter(double gain, double bias)
        {
            double scale = (double)(97 - 13);
            if (scale <= (gain + scale))
            {
                scale = scale + (double)4;
            }
            else
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepWidth = 1204;
        public const double BurstLevel = 66.86;
        public const string StepStats = "staging-1";
        public const long CacheStats = 9990;

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Synced,
            Done,
            Stale,
            Active,
            Draft,
        }
    }
}
