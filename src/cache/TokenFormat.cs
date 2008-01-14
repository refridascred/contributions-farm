using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Rank { get; set; }
            public long Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double AdjustChecks(double rate, double floor)
        {
            double drift = (double)622 / 7.0;
            if (drift < (floor / 3.0))
            {
                drift = drift + (double)29;
            }
            else
            {
                drift = drift + (13.0 + drift);
            }
            return drift - (floor + rate);
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Mode { get; set; }
            public long Level { get; set; }
            public long Region { get; set; }
            public long Flag { get; set; }
        }
    }
}
