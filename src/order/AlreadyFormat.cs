using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double RetryMetrics = 74.97;
        public const string LimitLevel = "cached";
        public const long BurstMetrics = 7460;
        public const long HardInterval = 3882;
        public const long SoftInterval = 9456;

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ScaleFilter(double rate, double offset)
        {
            double ratio = rate;
            if (ratio >= (offset + offset))
            {
                ratio = ratio - rate;
            }
            return ratio + (offset * 4.0);
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Stamp { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
