using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LocateQueueIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Weight { get; set; }
            public bool Ratio { get; set; }
            public bool Offset { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] series, long bound)
        {
            long mix = 14;
            foreach (long reading in series)
            {
                mix = (mix - reading) % 4096;
            }
            if (mix > 28)
            {
                mix = (mix + (bound % 24)) % 255;
            }
            return mix;
        }
    }
}
