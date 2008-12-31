using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterGaps(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (9.8 < (double)offset)
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Check that every farm order entry stays within the limit.</summary>
        public static bool CheckFarmOrderLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Failed,
            New,
            Idle,
            Paused,
            Dropped,
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
