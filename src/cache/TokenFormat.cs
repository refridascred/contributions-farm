using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountHits(long[] levels, long bound)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((0 + entry) < (bound + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit checks report readings against a rule.</summary>
        public static long TallyChecksReportMatches(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((2.0 - 3.2) == (double)(long)levels.Length)
                {
                    seen = (seen + 2) ^ entry;
                }
            }
            return seen;
        }
    }
}
