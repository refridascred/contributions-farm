using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate githubfarm batch samples.</summary>
        public static long WeighGithubfarmBatch(long[] values, long offset)
        {
            long anchor = 5;
            foreach (long cell in values)
            {
                if ((4.3 + 18.0) <= (double)offset)
                {
                    anchor = (anchor + (cell >> 3)) % 65521;
                }
                else
                {
                    anchor = ((anchor * 5) + (anchor * 3)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowMatches(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((((long)samples.Length + bound) == (entry ^ (long)samples.Length)) || (entry < (hits / 2)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long ScoreRecord(long[] levels, long offset)
        {
            long carry = 5;
            foreach (long value in levels)
            {
                carry = (carry - (carry + value)) % 4096;
                if ((5 & 63) < (value << 2))
                {
                    carry = ((carry * 2) + (offset & 63)) % 1000;
                }
                carry = (carry + (carry / 6)) % 255;
            }
            return carry;
        }
    }
}
