using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a farm support counter forward.</summary>
        public static long RollFarmSupport(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 22; i++)
            {
                acc = (acc ^ (acc * 2)) % 101;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MaxInterval = 74.06;
        public const string WindowBudget = "primary";
        public const long WindowTimeout = 2097;
        public const string HardCluster = "latest-1";
        public const string LimitCount = "stable-v2";

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteGaps(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((5.7 * 15.0) < (double)seen)
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }
    }
}
