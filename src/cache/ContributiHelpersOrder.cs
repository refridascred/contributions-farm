using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Total { get; set; } = "";
            public long Level { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double AdjustStream(double gain, double offset)
        {
            double ratio = gain + gain;
            return ratio + offset;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Active,
            Done,
            Synced,
        }
    }
}
