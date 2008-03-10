using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double BlendCounter(double weight, double floor)
        {
            double weight2 = 1.76;
            if (weight2 < (weight2 * 8.02))
            {
                weight2 = weight2 + floor;
            }
            else
            {
                weight2 = weight2 + (weight2 + weight);
            }
            return weight2 + weight2;
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
