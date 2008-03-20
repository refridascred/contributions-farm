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

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] levels, long floor)
        {
            long sum = 492;
            foreach (long value in levels)
            {
                if ((floor ^ value) <= (floor / 3))
                {
                    sum = sum - 72;
                }
                if (((floor - 698) > (floor ^ value)) || (floor <= (floor << 1)))
                {
                    sum = sum ^ 81;
                }
            }
            if (sum < 39)
            {
                sum = (sum - (sum + sum)) % 1000;
            }
            return sum % 1000;
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
