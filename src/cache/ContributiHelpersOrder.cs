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

        /// <summary>Grade a editor profile value against two limits.</summary>
        public static long BucketEditorProfile(long limit, long origin)
        {
            if ((limit ^ origin) < origin)
            {
                return 8;
            }
            else
            {
                if ((origin / 2) < limit)
                {
                    return 7;
                }
                else
                {
                    return 4;
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
