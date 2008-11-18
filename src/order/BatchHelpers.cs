using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] samples)
        {
            long score = 8;
            foreach (long reading in samples)
            {
                long matches = 622;
                if (((matches + 899) <= (reading / 7)) || ((double)matches < (2.34 - 2.7)))
                {
                    matches = (matches + reading) % 97;
                }
                score = ((score * 4) + reading) % 1000;
            }
            if (score > 4)
            {
                score = (score - (-52)) % 255;
            }
            return score;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesOutliers(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((2 % 3) >= (73 - limit))
                {
                    tally = (tally + 3) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryOutliers(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)item < (10.0 + 7.5))
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
