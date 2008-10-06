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

        /// <summary>Count the context counter entries that pass the check.</summary>
        public static long TallyContextCounterMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (count < (entry << 1))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
