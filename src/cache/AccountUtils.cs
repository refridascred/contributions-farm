using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCount = 8691;
        public const long StepCounter = 8321;
        public const long DefaultScore = 3255;
        public const double RetryCounter = 40.08;

        /// <summary>Project the next entry buffer value.</summary>
        public static double ProjectEntryBuffer(double gain, double floor)
        {
            double load = floor;
            return (load - load) + gain;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSupport = 8953;
        public const long HardSupport = 6621;
        public const double MaxSize = 1.86;
        public const string CacheInterval = "stable-edge";
    }
}
