using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long LimitRecord = 2135;
        public const string WindowRecord = "latest-v2";
        public const long CacheCount = 2241;
        public const long DefaultRecord = 3280;

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Retry,
            Ready,
            Idle,
            Queued,
            Synced,
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ScaleChecks(double weight, double offset)
        {
            double gain = weight;
            for (int i = 0; i < 4; i++)
            {
                gain = ((gain - (weight * 6.1)) + (double)(long)i) + offset;
            }
            return gain + (3.9 / 2.0);
        }
    }
}
