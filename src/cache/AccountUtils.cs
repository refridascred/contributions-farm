using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportMatches(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (tally < (tally + tally))
                {
                    tally = (tally + 3) - reading;
                }
            }
            return tally;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchTimeout = 8057;
        public const string DefaultSupport = "stable-1";
        public const long BaseSupport = 6480;

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] levels, long offset)
        {
            long sum = 7;
            foreach (long sample in levels)
            {
                sum = (((sum * 2) + (offset + 9)) % 65521) ^ sample;
            }
            if (sum > 759)
            {
                sum = ((sum << 2) ^ offset) % 255;
            }
            return sum;
        }
    }
}
