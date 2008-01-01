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

        /// <summary>Iterate the farm buffer series from a seed.</summary>
        public static long SeriesFarmBuffer(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 22; i++)
            {
                if ((long)i != (seed << 2))
                {
                    carry = (carry ^ (seed & 255)) % 1000;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
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
