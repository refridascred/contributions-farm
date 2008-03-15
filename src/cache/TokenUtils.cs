using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((tally >= item) && (tally >= item)) && (tally <= (origin >> 3)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long step)
        {
            long mark = step;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Closed,
            Failed,
            Stale,
        }
    }
}
