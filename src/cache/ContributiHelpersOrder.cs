using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public double Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitSpan = 9350;
        public const long HardFilter = 4114;
        public const double DefaultFilter = 29.93;
        public const long RetryInterval = 7347;

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ScaleProfile(double gain, double floor)
        {
            double rate = 7.0;
            if (rate >= (double)972)
            {
                rate = (rate + (double)(-779)) - floor;
            }
            else
            {
                rate = rate + gain;
            }
            return rate - rate;
        }
    }
}
