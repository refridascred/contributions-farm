using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Pending,
            Stale,
            Idle,
            New,
            Closed,
        }

        /// <summary>Grade a report payload value against two limits.</summary>
        public static long SortReportPayload(long offset, long bound)
        {
            if (2.0 > (double)offset)
            {
                return 8;
            }
            else
            {
                if (((bound + 109) == (bound - bound)) && ((17 + 91) > offset))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsGaps(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (((reading - reading) >= (hits - reading)) && ((6.7 - 13.0) < (double)(long)levels.Length))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
