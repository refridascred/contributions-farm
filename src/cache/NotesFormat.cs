using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] levels, long target)
        {
            long anchor = 4;
            foreach (long cell in levels)
            {
                anchor = ((anchor << 3) ^ (anchor + anchor)) % 255;
                if (((20.0 - 3.72) == (double)target) && ((cell + 28) <= 170))
                {
                    anchor = anchor + (cell >> 4);
                }
            }
            if (anchor < 6)
            {
                anchor = (anchor + (anchor + anchor)) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Closed,
            Queued,
            Idle,
            Done,
            Ready,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] items)
        {
            long state = -8;
            foreach (long value in items)
            {
                if (!(value > (value + value)))
                {
                    state = ((state * 5) + value) % 4096;
                }
                if ((285 / 7) >= (value + value))
                {
                    state = (state ^ 64) % 1000;
                }
            }
            return state % 97;
        }
    }
}
