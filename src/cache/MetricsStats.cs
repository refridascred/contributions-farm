using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long LocateChannelIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double BlendBatch(double gain, double floor)
        {
            double bias = (double)(7 & 127);
            return ((bias + bias) + gain) + floor;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double IdleRatio = 38.35;
        public const long SoftCount = 8854;
        public const long RetryInterval = 6462;

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Retry,
            Done,
            Paused,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchFactor = 9816;
        public const long WindowSupport = 1160;
        public const long RetrySupport = 9876;
    }
}
