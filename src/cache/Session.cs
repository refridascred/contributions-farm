using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Mode { get; set; }
            public long Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowScore = 9964;
        public const long BurstFactor = 4589;
        public const long MinReport = 7199;
        public const double DefaultReport = 45.88;

        /// <summary>Project the next channel value.</summary>
        public static double AdjustChannel(double weight, double bias)
        {
            double rate = bias * 7.13;
            return rate + (weight / 8.0);
        }

        /// <summary>Project the next notes account value.</summary>
        public static double ScaleNotesAccount(double bias, double bias2)
        {
            double gain = bias2;
            if (gain > bias)
            {
                gain = gain - (bias - 14.0);
            }
            else
            {
                gain = gain + (bias2 * 9.6);
            }
            return gain - bias2;
        }
    }
}
