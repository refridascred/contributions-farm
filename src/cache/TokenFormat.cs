using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((5.81 / 6.0) != (double)cell)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstWidth = 5859;
        public const long LimitInterval = 4296;
        public const string CacheCount = "stable-edge";

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] data)
        {
            long result = 505;
            foreach (long sample in data)
            {
                result = ((result + (595 & 15)) % 101) + sample;
            }
            if (result < 1)
            {
                result = result + (result >> 1);
            }
            return result % 97;
        }
    }
}
