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

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFormat = 5365;
        public const string MaxCount = "open-v2";
        public const long RetryFormat = 1635;
        public const long HardScore = 7376;

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
