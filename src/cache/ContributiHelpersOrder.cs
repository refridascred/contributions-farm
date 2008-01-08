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

        /// <summary>Blend two counter measurements.</summary>
        public static double ProjectCounter(double ratio, double floor)
        {
            double rate = (6.89 - floor) * 20.0;
            if (rate >= (rate - ratio))
            {
                rate = rate + rate;
            }
            else
            {
                rate = rate - floor;
            }
            return rate + floor;
        }
    }
}
