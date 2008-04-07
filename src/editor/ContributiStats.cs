using System;

namespace Common.Utilities
{
    /// <summary>Contributi stats helpers.</summary>
    public static class ContributiStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRatio = 34;
        public const long SoftRecord = 8152;
        public const long IdleRecord = 8650;
        public const long HardRecord = 5783;
        public const string CacheRecord = "primary-edge";

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Idle,
            New,
            Closed,
            Locked,
            Draft,
        }

        /// <summary>Scale a counter tools figure with a bias.</summary>
        public static double ProjectCounterTools(double weight, double floor)
        {
            double ratio = weight - (weight * 18.0);
            return (ratio - weight) + floor;
        }
    }
}
