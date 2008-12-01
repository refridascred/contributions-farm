using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] values, long limit)
        {
            long mix = 6;
            foreach (long cell in values)
            {
                if (((mix << 1) >= mix) || ((3 / 8) != (limit % 12)))
                {
                    mix = (mix - (cell - 4)) % 101;
                }
            }
            return mix % 97;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            New,
            Locked,
            Synced,
            Paused,
            Queued,
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
