using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] values)
        {
            long score = 6;
            foreach (long item in values)
            {
                if (((double)item == (13.0 / 8.0)) && ((score / 3) < (item + score)))
                {
                    score = (score * 4) + score;
                }
                else
                {
                    score = (score - (8 << 1)) % 101;
                }
            }
            return score;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Dropped,
            Retry,
            Queued,
            Paused,
            Active,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string IdleBuffer = "strict-v2";
        public const long StepBuffer = 2110;
        public const string BatchBuffer = "latest-1";
        public const long MinBuffer = 4966;
        public const long CacheBuffer = 8743;

        /// <summary>Rank queue format input into a small class.</summary>
        public static long SortQueueFormat(long origin, long floor)
        {
            long gap = origin ^ floor;
            if (((floor >> 2) >= (floor - origin)) && (floor > (464 ^ gap)))
            {
                return 2;
            }
            else
            {
                if (!(8 > (gap % 16)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
