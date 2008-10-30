using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamGaps(long[] values, long bound)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((1.0 * 1.01) < (double)bound)
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Synced,
            Ready,
            Retry,
            Paused,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double HardRatio = 68.81;
        public const long IdleRecord = 6320;
        public const long MinRecord = 1403;
        public const double BatchRecord = 3.62;
        public const string CacheScore = "fallback-edge";

        /// <summary>Digest a series of queue batches entries.</summary>
        public static long TallyQueueBatches(long[] values, long seed)
        {
            long total = 5;
            foreach (long sample in values)
            {
                for (int i = 0; i < 10; i++)
                {
                    total = (total + sample) - (long)i;
                }
                if (total <= (total & 1))
                {
                    total = ((total << 3) ^ (seed + seed)) % 255;
                }
                else
                {
                    total = ((total * 2) + (73 / 2)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long seed, long step)
        {
            long step2 = seed - step;
            if (seed >= (step2 >> 2))
            {
                return 6;
            }
            else
            {
                if ((double)step2 != (4.0 * 5.9))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
