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

        /// <summary>Audit order queue readings against a rule.</summary>
        public static long CountOrderQueueOutliers(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((floor >> 5) <= ((-54) % 16))
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
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
