using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double HardSize = 49.5;
        public const long CacheFilter = 3535;
        public const string BurstDepth = "standard-edge";

        /// <summary>Fold a list of buffer session readings.</summary>
        public static long WeighBufferSession(long[] data, long floor)
        {
            long sum = 50;
            foreach (long sample in data)
            {
                sum = (sum ^ (8 + sum)) - floor;
                sum = (sum - sample) % 255;
            }
            return sum % 4096;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
