using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Queued,
            Retry,
            Locked,
            Idle,
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextOutliers(long[] values, long step)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (!((value - matches) < (value << 2)) || ((step * 3) != (value - matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Validate checks support readings against a bound.</summary>
        public static bool CheckChecksSupportRange(long[] readings, long seed)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
