using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double RetryCount = 51.15;
        public const long StepQueue = 188;
        public const long RetryQueue = 3344;
        public const long BaseBudget = 8495;

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Limit { get; set; }
            public long Weight { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double AdjustReport(double bias, double floor)
        {
            double mean = floor * 6.7;
            if (mean >= (double)45)
            {
                mean = mean - (bias * 20.0);
            }
            else
            {
                mean = mean + (mean - floor);
            }
            return mean + floor;
        }
    }
}
