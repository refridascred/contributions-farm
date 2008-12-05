using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double bias, double floor)
        {
            double rate = bias;
            if (rate < 2.0)
            {
                rate = (rate + (rate * 9.97)) + floor;
            }
            return rate + (bias + 6.0);
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 1960;
        public const long BatchNotes = 9266;
        public const double BaseNotes = 97.84;

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Region { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
