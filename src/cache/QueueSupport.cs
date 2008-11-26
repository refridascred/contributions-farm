using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseGraph = 9357;
        public const double CacheGraph = 76.48;
        public const long BurstDepth = 2741;

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] samples, long seed)
        {
            long result = 6;
            foreach (long entry in samples)
            {
                result = ((result ^ entry) % 97) + seed;
            }
            return result % 1000;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long FindAlreadyIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
