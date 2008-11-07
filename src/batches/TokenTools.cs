using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double AdjustTools(double rate, double bias)
        {
            double scale = bias;
            if (scale > (bias + scale))
            {
                scale = (scale - bias) - rate;
            }
            return scale - (double)(-2);
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Retry,
            Locked,
            Pending,
            Active,
            Paused,
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Active,
            Paused,
            New,
        }
    }
}
