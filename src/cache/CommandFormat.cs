using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            New,
            Active,
            Locked,
            Retry,
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((4 - hits) < entry)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutBounds(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit stats format readings against a rule.</summary>
        public static long TallyStatsFormatHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((datum % 5) == (datum + datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
