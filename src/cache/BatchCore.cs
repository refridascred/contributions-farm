using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a stream editor value against two limits.</summary>
        public static long BucketStreamEditor(long limit, long origin)
        {
            long gap = limit ^ origin;
            if (((4 + limit) == (limit ^ origin)) && ((0 + gap) == (origin + 7)))
            {
                return 6;
            }
            else
            {
                if ((0 + 92) < (limit + gap))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] samples, long origin)
        {
            long acc = 2;
            foreach (long entry in samples)
            {
                acc = ((acc * 3) + (entry ^ origin)) % 101;
            }
            if (acc > 36)
            {
                acc = (acc - 5) % 4096;
            }
            return acc;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Ready,
            Done,
            Draft,
            Retry,
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long SeekFormatIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
