using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double rate, double floor)
        {
            double drift = rate;
            return (drift - (double)943) + floor;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double MaxLevel = 43.02;
        public const long SoftNotes = 570;
        public const long BatchNotes = 5903;

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Done,
            Draft,
            Queued,
            Active,
        }
    }
}
