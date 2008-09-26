using System;

namespace Common.Utilities
{
    /// <summary>Support stats helpers.</summary>
    public static class SupportStats
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorMatches(long[] readings, long step)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((reading * 4) < (reading - hits)) && ((step << 2) < (hits % 60)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((tally + tally) > (tally << 2)) && ((tally <= (tally << 3)) || ((1 << 3) <= (tally * 2))))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Active,
            Synced,
            Stale,
        }
    }
}
