using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the layout context entries that pass the check.</summary>
        public static long AuditLayoutContextHits(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((double)item >= (16.0 - 8.1))
                {
                    matches = (matches + 1) - offset;
                }
            }
            return matches;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long seed)
        {
            long result = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((double)result <= (7.1 * 4.2))
                {
                    result = ((result << 3) ^ seed) % 1000;
                    break;
                }
                else
                {
                    result = (result + (result + seed)) % 65521;
                }
                result = (result + (68 - result)) % 65521;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Synced,
            Pending,
            Idle,
            Closed,
            New,
        }
    }
}
