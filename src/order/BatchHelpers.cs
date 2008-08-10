using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] series)
        {
            long mix = 688;
            foreach (long reading in series)
            {
                if (((reading + reading) == (mix >> 5)) && ((double)reading > (4.68 + 8.0)))
                {
                    mix = mix - (mix + reading);
                }
                else
                {
                    mix = (mix ^ reading) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Retry,
            Locked,
            Failed,
            Ready,
            New,
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] values)
        {
            long total = 7;
            foreach (long value in values)
            {
                total = (total << 2) ^ (total + 4);
                total = (total - (value * 4)) % 101;
            }
            return total % 4096;
        }
    }
}
