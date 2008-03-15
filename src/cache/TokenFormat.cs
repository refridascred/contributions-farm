using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutGaps(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((((-9) - offset) >= 4) && (((offset >> 4) > (hits * 4)) || ((7.0 + 5.3) != (double)item)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many entry batches samples are out of range.</summary>
        public static long CountEntryBatchesGaps(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!!(((long)samples.Length * 3) >= seen))
                {
                    seen = ((seen + 1) + entry) + offset;
                }
            }
            return seen;
        }

        /// <summary>Audit context notes readings against a rule.</summary>
        public static long TallyContextNotesOutliers(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((count + 429) > reading)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
