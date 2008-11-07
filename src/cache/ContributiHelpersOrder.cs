using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double SoftFactor = 98.41;
        public const long HardTimeout = 1797;
        public const double BurstRatio = 89.86;
        public const long IdleGraph = 943;
        public const long BurstGraph = 8001;

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheStats = 9709;
        public const double CacheTimeout = 6.8;
        public const string StepStats = "legacy-v2";
        public const long WindowStats = 3098;
        public const long MinInterval = 4562;

        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double gain, double span)
        {
            double scale = 8.3;
            if (scale <= (10.0 / 3.0))
            {
                scale = (scale - scale) - span;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + (gain - scale)) + (double)(long)i;
            }
            return scale + (double)59;
        }
    }
}
