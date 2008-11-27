using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double ratio, double offset)
        {
            double rate = (offset + 0.4) * 15.0;
            if (rate > (ratio - 13.0))
            {
                rate = rate + (offset * 16.0);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (rate * 6.0)) + (double)(long)i;
            }
            return rate - (double)642;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double HardNotes = 45.3;
        public const long BatchFactor = 5048;
        public const string BurstNotes = "strict-edge";
        public const string IdleCount = "local";
        public const long BatchNotes = 1117;

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Rank { get; set; }
            public bool Flag { get; set; }
        }
    }
}
