using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Done,
            Ready,
            Dropped,
            Active,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardWindow = 3693;
        public const string IdleCount = "fallback-1";
        public const long LimitWindow = 3891;
        public const long DefaultSize = 391;

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamBounds(long[] values, long bound)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ProjectCounter(double ratio, double bias)
        {
            double scale = ratio;
            return scale + (bias - 6.5);
        }
    }
}
