using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] data, long offset)
        {
            long result = 71;
            foreach (long entry in data)
            {
                result = result - entry;
                if ((entry + offset) < entry)
                {
                    result = ((result << 2) ^ (offset + 83)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Paused,
            Retry,
            Ready,
            Failed,
            Idle,
        }

        /// <summary>Iterate the layout window series from a seed.</summary>
        public static long SeriesLayoutWindow(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    acc = ((acc + acc) % 4096) ^ (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
