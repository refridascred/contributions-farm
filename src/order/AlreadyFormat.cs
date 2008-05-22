using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Region { get; set; } = "";
            public bool Rank { get; set; }
            public long Count { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Region { get; set; }
            public long Limit { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BurstLevel = 5.01;
        public const double DefaultGraph = 48.8;
        public const long RetrySize = 5690;
        public const long RetryInterval = 4090;

        /// <summary>Adjust a support batch reading.</summary>
        public static double AdjustSupportBatch(double rate, double floor)
        {
            double mean = rate - 8.86;
            return (mean - (6.8 * 0.83)) + floor;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
