using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long IdleOrder = 84;
        public const long DefaultOrder = 4360;
        public const double BatchOrder = 85.72;
        public const double LimitSize = 55.17;

        /// <summary>Define profile limits and defaults.</summary>
        public const double IdleScore = 71.76;
        public const long BaseSpan = 4466;
        public const long IdleRatio = 6022;
        public const long CacheProfile = 8397;

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaMatches(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (!((sample ^ tally) <= tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
