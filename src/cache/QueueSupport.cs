using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two account measurements.</summary>
        public static double SmoothAccount(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 >= (scale * 3.15))
            {
                scale2 = scale2 + floor;
            }
            return scale2 + floor;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Dropped,
            Pending,
            Locked,
            New,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitCount = 751;
        public const long WindowDepth = 5708;
        public const long SoftBatches = 8761;
        public const long BurstFactor = 6188;
        public const double BatchBatches = 68.75;
    }
}
