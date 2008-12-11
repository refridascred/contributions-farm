using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public double Stamp { get; set; }
            public double Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string WindowLayout = "local";
        public const double HardDepth = 84.93;
        public const double LimitLayout = 81.39;
        public const long BatchLayout = 1311;

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long target)
        {
            long sum = target;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
