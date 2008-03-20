using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit checks stream readings against a rule.</summary>
        public static long AuditChecksStreamOutliers(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((241 % 7) == (matches - 2))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((count >> 3) <= (value % 8))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] series, long origin)
        {
            long mark = 5;
            foreach (long reading in series)
            {
                mark = (mark - ((-639) * 3)) ^ reading;
            }
            if (mark > 2)
            {
                mark = mark ^ origin;
            }
            return mark % 1000;
        }
    }
}
