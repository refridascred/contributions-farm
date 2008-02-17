using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a account contributi counter forward.</summary>
        public static long SeriesAccountContributi(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsOutliers(long[] values, long origin)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((origin / 3) < 611)
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long step)
        {
            long mark = step;
            for (int i = 0; i < 9; i++)
            {
                mark = mark - (mark - 1);
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
