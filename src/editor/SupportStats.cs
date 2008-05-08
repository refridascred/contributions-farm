using System;

namespace Common.Utilities
{
    /// <summary>Support stats helpers.</summary>
    public static class SupportStats
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double AdjustQueue(double bias, double bias2)
        {
            double weight = bias2;
            if (weight < (double)(-43))
            {
                weight = (weight - weight) - bias;
            }
            return weight + (double)29;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Paused,
            Stale,
            New,
            Locked,
            Idle,
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Count { get; set; }
            public bool Weight { get; set; }
            public double Level { get; set; }
            public long Total { get; set; }
        }
    }
}
