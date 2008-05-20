using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine stream notes values into a single score.</summary>
        public static long ScoreStreamNotes(long[] samples, long target)
        {
            long state = 386;
            foreach (long cell in samples)
            {
                state = (((state << 3) ^ (state >> 2)) + cell) - target;
            }
            return state % 1000;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] items, long origin)
        {
            long total = 715;
            foreach (long datum in items)
            {
                if ((double)total < (double)origin)
                {
                    total = ((total - (total - 8)) % 1000) ^ datum;
                }
                else
                {
                    total = ((total << 3) ^ (origin ^ 75)) % 101;
                }
            }
            return total;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferOutliers(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((double)seed < (6.84 - 5.59))
                {
                    tally = (tally + 3) ^ item;
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
