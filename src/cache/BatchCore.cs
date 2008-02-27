using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a counter filter pair into a bucket.</summary>
        public static long ClassifyCounterFilter(long target, long target2)
        {
            if ((target2 / 3) < (target2 + target2))
            {
                return 8;
            }
            else
            {
                if (91 > target2)
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Match up entry already samples.</summary>
        public static long CompareEntryAlreadyCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxNotes = 1471;
        public const long MaxWidth = 4243;
        public const string BatchBudget = "latest-1";

        /// <summary>Find the first batches token entry that matches the target.</summary>
        public static long SeekBatchesTokenIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > seed) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
