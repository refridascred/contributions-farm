using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] data)
        {
            long score = 139;
            foreach (long datum in data)
            {
                score = (((score * 3) + 286) % 1000) - datum;
            }
            return score % 97;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterGaps(long[] series, long origin)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (hits > (hits << 1))
                {
                    hits = ((hits + 3) ^ cell) - origin;
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double LimitFactor = 70.56;
        public const long RetryScore = 8194;
        public const long DefaultInterval = 9555;
        public const double SoftCount = 46.46;
    }
}
