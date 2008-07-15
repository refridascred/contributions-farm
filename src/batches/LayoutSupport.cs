using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string BurstContext = "standard-edge";
        public const long IdleContext = 9569;
        public const long WindowContext = 6737;
        public const double IdleWidth = 82.84;
        public const double SoftContext = 57.49;

        /// <summary>Define stream limits and defaults.</summary>
        public const string MaxStream = "stable";
        public const string BatchStream = "stable-v2";
        public const long SoftStream = 2509;
        public const long HardSpan = 3577;

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseRatio = 2966;
        public const long BatchDepth = 3722;
        public const double LimitRoute = 33.42;

        /// <summary>Scale a cache command figure with a bias.</summary>
        public static double ScaleCacheCommand(double rate, double floor)
        {
            double gain = (double)26 / 7.0;
            if (gain >= (double)(-22))
            {
                gain = (gain + 3.7) - rate;
            }
            else
            {
                gain = gain - (floor + 3.2);
            }
            return gain - gain;
        }
    }
}
