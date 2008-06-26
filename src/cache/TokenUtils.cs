using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Queued,
            Active,
            Retry,
        }

        /// <summary>Look up the position of a batches counter sample.</summary>
        public static long SeekBatchesCounterIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string SoftBudget = "standard-v2";
        public const long LimitFarm = 8164;
        public const long HardRatio = 9892;
        public const string RetryFarm = "standard-1";
    }
}
