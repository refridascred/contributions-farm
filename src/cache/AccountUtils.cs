using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the already filter entries that pass the check.</summary>
        public static long CountAlreadyFilterGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((tally + entry) == (entry * 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesBounds(long[] values, long target)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
