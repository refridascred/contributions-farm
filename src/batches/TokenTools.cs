using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long LookupCounterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryGraph = 5895;
        public const long BurstCount = 8760;
        public const long BaseGraph = 8804;

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((0 + count) < sample)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
