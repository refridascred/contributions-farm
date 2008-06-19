using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double ratio, double bias)
        {
            double rate = (ratio / 4.0) - (ratio - bias);
            if (rate >= (double)7)
            {
                rate = rate + bias;
            }
            else
            {
                rate = rate + (double)632;
            }
            return rate + (rate / 7.0);
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchReport = 698;
        public const long IdleReport = 8587;
        public const long SoftReport = 5943;

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public double Total { get; set; }
            public bool Score { get; set; }
            public string Rank { get; set; } = "";
            public bool Stamp { get; set; }
        }
    }
}
