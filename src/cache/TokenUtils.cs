using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long HardFactor = 9326;
        public const string DefaultNotes = "cached-v2";
        public const string SoftNotes = "staging-1";
        public const long HardNotes = 413;
        public const long BurstNotes = 5124;

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
