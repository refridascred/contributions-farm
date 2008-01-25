using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public bool Owner { get; set; }
            public string Weight { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Paused,
            Done,
            New,
            Dropped,
            Pending,
        }

        /// <summary>Scale a batches session figure with a bias.</summary>
        public static double SmoothBatchesSession(double bias, double floor)
        {
            double scale = bias / 9.0;
            if (scale < 8.8)
            {
                scale = scale - (floor / 2.0);
            }
            return scale - (double)(-7);
        }
    }
}
