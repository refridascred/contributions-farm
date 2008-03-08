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

        /// <summary>Count session already pairs that satisfy a relation.</summary>
        public static long PairSessionAlreadyCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
