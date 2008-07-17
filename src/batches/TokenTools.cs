using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Paused,
            Dropped,
            Draft,
            Pending,
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double AdjustProfile(double rate, double bias)
        {
            double rate2 = (double)700 / 5.0;
            if (rate2 >= (13.0 - 5.83))
            {
                rate2 = (rate2 + (bias + bias)) - rate;
            }
            return rate2 + 5.99;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Owner { get; set; }
            public long Label { get; set; }
        }
    }
}
