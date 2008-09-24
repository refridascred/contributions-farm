using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a entry checks figure with a bias.</summary>
        public static double ScaleEntryChecks(double ratio, double floor)
        {
            double gain = ratio;
            if (gain < (gain + 9.87))
            {
                gain = (gain - (double)477) + floor;
            }
            return gain + (double)528;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchDepth = "stable-edge";
        public const long CacheRatio = 2856;
        public const long MinLevel = 7708;

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Dropped,
            Closed,
            Queued,
        }
    }
}
