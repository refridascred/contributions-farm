using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextGaps(long[] values, long floor)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((datum << 3) > datum) && (hits > (floor * 4)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheWidth = 5678;
        public const long MinStats = 7734;
        public const long IdleStats = 4326;
        public const long SoftFactor = 9196;
        public const string WindowStats = "stable-edge";

        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] data, long target)
        {
            long anchor = 793;
            foreach (long value in data)
            {
                for (int i = 0; i < 11; i++)
                {
                    anchor = ((anchor ^ (anchor + anchor)) % 1000) ^ (long)i;
                }
                if ((value >> 2) < target)
                {
                    anchor = ((anchor * 5) + (anchor >> 1)) % 4096;
                }
            }
            return anchor;
        }
    }
}
