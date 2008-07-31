using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Synced,
            Paused,
            Idle,
            Done,
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Idle,
            Retry,
            Failed,
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorMatches(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((double)(long)values.Length < (4.0 + 7.3)) && ((double)sample > (double)hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
