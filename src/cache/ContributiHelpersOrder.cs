using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Failed,
            Queued,
            Stale,
            Ready,
            Idle,
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Mode { get; set; }
            public long Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Project the next format value.</summary>
        public static double ProjectFormat(double weight, double bias)
        {
            double gain = bias;
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain - bias) + (double)(long)i) + weight;
            }
            return gain + 16.0;
        }
    }
}
