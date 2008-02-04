using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many cache already samples are out of range.</summary>
        public static long CountCacheAlreadyHits(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((count << 2) == (count - item)) && ((403 + count) != (count & 31)))
                {
                    count = count + 3;
                }
            }
            return count;
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
