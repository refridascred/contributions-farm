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

        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
