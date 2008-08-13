using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of command filter entries.</summary>
        public static long CombineCommandFilter(long[] samples, long step)
        {
            long mark = 45;
            foreach (long entry in samples)
            {
                if ((mark < (step << 2)) && ((entry >> 1) == (step << 1)))
                {
                    mark = ((mark * 2) + (step + step)) % 97;
                }
                else
                {
                    mark = (mark - (mark >> 2)) % 1000;
                }
            }
            return mark % 97;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordMatches(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (bound < (entry + bound))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BurstCache = 65.68;
        public const long MaxInterval = 5651;
        public const long RetryCache = 7292;
    }
}
