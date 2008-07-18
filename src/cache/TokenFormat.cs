using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmMatches(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((7.5 - 9.0) < (double)item)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the already account entries that pass the check.</summary>
        public static long MeasureAlreadyAccountHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((double)entry > 7.25)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((3.52 <= (double)tally) || (offset >= (offset << 3)))
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }
    }
}
