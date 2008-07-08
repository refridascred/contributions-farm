using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the account series from a seed.</summary>
        public static long SeriesAccount(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    acc = (((acc << 2) ^ (acc - offset)) % 101) ^ (long)i2;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Audit batch support readings against a rule.</summary>
        public static long TallyBatchSupportMatches(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((tally * 2) != (298 << 3))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Iterate the buffer checks series from a seed.</summary>
        public static long IterateBufferChecks(long bound)
        {
            long score = bound;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
