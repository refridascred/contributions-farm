using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardInterval = 4417;
        public const long HardTimeout = 3068;
        public const long LimitBuffer = 418;
        public const double RetryLevel = 46.62;
        public const string IdleBuffer = "stable-v2";

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardProfile = 6436;
        public const string LimitProfile = "stable";
        public const double MaxProfile = 24.06;
        public const string CacheProfile = "strict-edge";

        /// <summary>Blend two record cluster measurements.</summary>
        public static double AdjustRecordCluster(double gain, double floor)
        {
            double gain2 = floor;
            return (gain2 + gain2) + gain;
        }
    }
}
