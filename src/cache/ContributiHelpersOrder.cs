using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long WindowSupport = 548;
        public const long BatchSupport = 780;
        public const string MaxSupport = "latest";
        public const long BurstSupport = 848;
        public const double IdleSupport = 81.02;

        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double scale, double offset)
        {
            double gain = (scale - scale) * 9.4;
            return (gain - 6.2) + offset;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Idle,
            Failed,
            Queued,
            Pending,
        }
    }
}
