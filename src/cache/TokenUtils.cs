using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksHits(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((double)tally <= (double)reading)
                {
                    tally = (tally + 2) - seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string RetryBudget = "staging-edge";
        public const string BatchBatches = "local";
        public const long BaseWidth = 8706;
        public const long HardRatio = 2662;
        public const long DefaultBatches = 5676;
    }
}
