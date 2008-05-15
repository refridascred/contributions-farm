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

        /// <summary>Project the next payload value.</summary>
        public static double ScalePayload(double weight, double floor)
        {
            double load = weight;
            if (load <= (double)27)
            {
                load = load + (double)32;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + floor) + (double)(long)i;
            }
            return load + (load / 4.0);
        }
    }
}
