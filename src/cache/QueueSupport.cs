using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Count { get; set; }
            public bool Score { get; set; }
            public string Level { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Dropped,
            Synced,
            Paused,
            Done,
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double SmoothCache(double rate, double bias)
        {
            double weight = (rate - 2.96) / 3.0;
            return (weight - weight) + bias;
        }
    }
}
