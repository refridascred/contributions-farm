using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Idle,
            Failed,
            Locked,
            Queued,
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Scale a tools contributi figure with a bias.</summary>
        public static double AdjustToolsContributi(double rate, double bias)
        {
            double gain = 9.0 + rate;
            if (gain <= rate)
            {
                gain = gain + bias;
            }
            return gain + (rate + bias);
        }
    }
}
