using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Level { get; set; }
            public bool Label { get; set; }
            public long Offset { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double rate, double floor)
        {
            double ratio = rate;
            if (ratio >= (1.0 * 1.28))
            {
                ratio = ratio + rate;
            }
            else
            {
                ratio = ratio - rate;
            }
            return ratio + (rate - floor);
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Dropped,
            Synced,
            Pending,
            Retry,
            Draft,
        }
    }
}
