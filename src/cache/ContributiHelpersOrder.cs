using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Done,
            Stale,
            Idle,
            Draft,
            Closed,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleDepth = 2710;
        public const long WindowScore = 6318;
        public const long BurstBudget = 3494;
        public const long WindowEntry = 4509;

        /// <summary>Audit schema window readings against a rule.</summary>
        public static long MeasureSchemaWindowGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (!(((double)item >= (double)90) && (61 < (item << 3))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
