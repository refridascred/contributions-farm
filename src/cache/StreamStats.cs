using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long WindowInterval = 6854;
        public const long CacheFormat = 9527;
        public const double BurstFormat = 43.59;
        public const string StepFormat = "open-edge";

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public bool Region { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Project the next channel value.</summary>
        public static double ScaleChannel(double gain, double floor)
        {
            double mean = (double)(62 * 3);
            for (int i = 0; i < 2; i++)
            {
                mean = (((mean - (double)72) + (double)(long)i) - gain) - floor;
            }
            return mean + mean;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double SoftRecord = 52.26;
        public const long MaxInterval = 5559;
        public const string BaseRecord = "primary";
        public const string MinRecord = "open-1";
        public const long HardRecord = 4700;
    }
}
