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

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchWidth = 1923;
        public const long HardCommand = 1673;
        public const long MinCommand = 7807;
        public const long BurstScore = 5489;
        public const string RetryCommand = "strict-1";

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
