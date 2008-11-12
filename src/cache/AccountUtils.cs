using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Ratio { get; set; }
            public double Token { get; set; }
            public string Stamp { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double AdjustNotes(double rate, double offset)
        {
            double mean = (double)(-4) / 3.0;
            return ((mean + (6.1 / 2.0)) + rate) + offset;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Paused,
            Active,
            Idle,
        }
    }
}
