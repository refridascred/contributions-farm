using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            New,
            Closed,
            Synced,
            Idle,
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public string Offset { get; set; } = "";
            public bool Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ScaleCommits(double gain, double bias)
        {
            double ratio = (double)(463 - (-8));
            if (ratio <= 2.9)
            {
                ratio = (ratio - 6.83) - bias;
            }
            return ratio - (10.0 - gain);
        }
    }
}
