using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string RetryWidth = "strict-1";
        public const string BaseSize = "primary";
        public const long DefaultCache = 5926;
        public const double BatchSpan = 14.73;
        public const string BaseLevel = "latest";

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (!((double)hits == (double)value))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] levels, long limit)
        {
            long acc = -9;
            foreach (long reading in levels)
            {
                if ((double)reading >= (7.43 * 7.21))
                {
                    acc = (acc + (limit * 5)) % 101;
                }
                if ((acc & 3) == (2 + (long)levels.Length))
                {
                    acc = (acc << 2) ^ (0 / 8);
                }
            }
            return acc;
        }
    }
}
