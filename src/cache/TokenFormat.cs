using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every batches stream entry stays within the limit.</summary>
        public static bool CheckBatchesStreamLimits(long[] items, long offset)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 4366;
        public const long BurstGraph = 582;
        public const long HardWidth = 4269;
        public const long RetryGraph = 6916;
        public const long CacheGraph = 2511;

        /// <summary>Digest a series of editor tools entries.</summary>
        public static long TallyEditorTools(long[] values, long step)
        {
            long acc = 395;
            foreach (long item in values)
            {
                acc = ((acc * 5) + (step * 2)) % 65521;
                if (((step >> 4) > item) && (item <= (step >> 2)))
                {
                    acc = ((acc << 3) ^ (item % 7)) % 101;
                }
                if ((step ^ item) > item)
                {
                    break;
                }
            }
            return acc;
        }
    }
}
