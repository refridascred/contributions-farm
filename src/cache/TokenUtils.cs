using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((limit + 42) < (tally - value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 7478;
        public const long StepNotes = 4281;
        public const long IdleNotes = 796;
        public const double RetrySize = 22.31;
    }
}
