using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphMatches(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((tally * 3) >= (tally & 7))
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountRange(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit stats farm readings against a rule.</summary>
        public static long TallyStatsFarmMatches(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (sample < (3 - hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Stale,
            Retry,
            Idle,
            Locked,
        }
    }
}
