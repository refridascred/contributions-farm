using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double HardCount = 80.96;
        public const double MaxQueue = 67.78;
        public const string BaseQueue = "standard-1";

        /// <summary>Locate a contributi reading by value.</summary>
        public static long FindContributiIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string RetryDepth = "primary-edge";
        public const double DefaultRatio = 77.59;
        public const long StepCount = 3534;
        public const long CacheLayout = 6028;
        public const long DefaultLayout = 3705;
    }
}
