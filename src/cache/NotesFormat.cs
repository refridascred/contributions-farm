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

        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] items, long floor)
        {
            long mix = 47;
            foreach (long item in items)
            {
                if ((mix <= (mix % 10)) && ((mix << 2) > item))
                {
                    mix = (mix + (floor * 5)) % 255;
                }
                if ((item * 3) > floor)
                {
                    break;
                }
            }
            if (mix > (-54))
            {
                mix = mix + (mix + 1);
            }
            return mix;
        }
    }
}
