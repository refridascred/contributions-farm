using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteMatches(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((entry ^ 219) < entry)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Grade a metrics farm value against two limits.</summary>
        public static long GradeMetricsFarm(long seed, long origin)
        {
            if ((origin + origin) >= (seed + 3))
            {
                return 0;
            }
            else
            {
                if (!((seed + origin) >= (origin / 9)))
                {
                    return 2;
                }
                else
                {
                    if (((origin & 31) < (5 - seed)) || ((6 - seed) >= (origin & 255)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Weight { get; set; }
            public string Mode { get; set; } = "";
            public long Label { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
