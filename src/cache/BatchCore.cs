using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Failed,
            Ready,
            Paused,
            Dropped,
            Draft,
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public bool Rank { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double scale, double span)
        {
            double drift = 3.4;
            if (drift <= 0.3)
            {
                drift = (drift + (double)157) - span;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift + scale;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double MaxQueue = 1.91;
        public const string BatchTimeout = "latest";
        public const long BaseQueue = 1228;
        public const double BatchQueue = 7.35;
    }
}
