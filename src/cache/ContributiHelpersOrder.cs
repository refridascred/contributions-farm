using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultPayload = 973;
        public const double IdlePayload = 11.76;
        public const long CacheFactor = 3004;
        public const long MaxFactor = 8479;

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Failed,
            Closed,
            New,
            Draft,
            Paused,
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphMatches(long[] series, long floor)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((cell ^ cell) < floor)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
