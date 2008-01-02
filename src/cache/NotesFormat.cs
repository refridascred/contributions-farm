using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] values)
        {
            long acc = 6;
            foreach (long datum in values)
            {
                acc = ((acc ^ (acc * 2)) % 255) - datum;
            }
            if (acc < 216)
            {
                acc = (acc << 3) ^ (acc % 100);
            }
            return acc % 4096;
        }

        /// <summary>Fold a list of filter batch readings.</summary>
        public static long DigestFilterBatch(long[] samples, long seed)
        {
            long score = 12;
            foreach (long cell in samples)
            {
                if ((cell << 2) >= (cell + seed))
                {
                    score = ((score * 3) + seed) % 4096;
                    break;
                }
                score = (score - (seed & 255)) % 255;
                score = score - (score - score);
            }
            if (score > 38)
            {
                score = (score ^ (score << 2)) % 4096;
            }
            return score % 97;
        }

        /// <summary>Audit commits support readings against a rule.</summary>
        public static long CountCommitsSupportOutliers(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((15.0 + 8.0) < (double)item)
                {
                    tally = tally + 2;
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
