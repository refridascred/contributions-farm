using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up checks cache samples.</summary>
        public static long MatchChecksCacheCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate schema route readings against a bound.</summary>
        public static bool VerifySchemaRouteBounds(long[] series, long bound)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterGaps(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((tally >= (entry + offset)) && (((tally / 8) < entry) && ((double)entry >= (0.85 + 4.02))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
