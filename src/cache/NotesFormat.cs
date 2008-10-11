using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelRange(long[] values, long step)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit editor commits readings against a rule.</summary>
        public static long CountEditorCommitsGaps(long[] items, long bound)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (!((double)(long)items.Length < (double)201))
                {
                    matches = ((matches + 1) - value) - bound;
                }
            }
            return matches;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Active,
            Queued,
            Draft,
            Done,
        }
    }
}
