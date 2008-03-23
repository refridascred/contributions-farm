using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double scale, double bias)
        {
            double weight = 5.9;
            if (weight >= scale)
            {
                weight = weight - (4.4 + 3.7);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (bias - bias)) + (double)(long)i;
            }
            return weight + bias;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Retry,
            Closed,
            Stale,
            Paused,
            Failed,
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Ratio { get; set; }
            public bool Stamp { get; set; }
            public long Level { get; set; }
            public long Weight { get; set; }
        }
    }
}
