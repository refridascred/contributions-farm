using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstDepth = 8790;
        public const string BaseInterval = "staging-edge";
        public const double HardScore = 57.93;
        public const double BaseEntry = 36.23;

        /// <summary>Blend two window measurements.</summary>
        public static double ScaleWindow(double ratio, double offset)
        {
            double scale = offset;
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale + scale) + (double)(long)i) + ratio;
            }
            return scale + (scale * 5.01);
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Locked,
            Idle,
            Paused,
            Queued,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BurstTimeout = "local";
        public const string LimitCounter = "strict-edge";
        public const string SoftRatio = "cached-1";
    }
}
