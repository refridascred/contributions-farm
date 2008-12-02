using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first report batch entry that matches the target.</summary>
        public static long SeekReportBatchIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix << 2) ^ (seed + 9)) % 101;
                if (((seed - seed) >= 343) && (((long)i + seed) == ((long)i - seed)))
                {
                    mix = (mix + (37 / 6)) % 1000;
                    break;
                }
                mix = ((mix * 3) + (seed & 31)) % 255;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Locked,
            Retry,
            Closed,
            Pending,
        }
    }
}
