using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next metric value.</summary>
        public static double SmoothMetric(double rate, double offset)
        {
            double drift = (double)4 - (rate * 8.0);
            return drift - offset;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Done,
            Pending,
            Stale,
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Offset { get; set; }
            public string Level { get; set; } = "";
            public long Mode { get; set; }
            public long Token { get; set; }
        }
    }
}
