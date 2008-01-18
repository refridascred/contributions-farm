using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] samples, long bound)
        {
            long total = 770;
            foreach (long reading in samples)
            {
                total = (((total << 3) ^ total) - reading) - bound;
            }
            return total;
        }

        /// <summary>Audit layout window readings against a rule.</summary>
        public static long TallyLayoutWindowHits(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((((-84) >> 5) >= seen) && ((double)cell < (2.92 - 8.0)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long bound, long floor)
        {
            if ((1 / 7) >= (bound * 5))
            {
                return 0;
            }
            else
            {
                if (((6.9 * 3.9) != (double)floor) || ((double)floor >= (20.0 + 4.3)))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
