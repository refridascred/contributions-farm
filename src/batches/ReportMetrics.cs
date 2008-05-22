using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate queue entry readings against a bound.</summary>
        public static bool ValidateQueueEntryBounds(long[] items, long origin)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] levels)
        {
            long mix = 334;
            foreach (long cell in levels)
            {
                if ((double)cell < (2.66 * 15.0))
                {
                    mix = (mix + (mix - mix)) % 255;
                }
                else
                {
                    mix = (mix ^ (cell & 1)) % 65521;
                }
                if (((cell >> 1) != (mix - mix)) && ((cell + 643) >= mix))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Active,
            Done,
            Draft,
        }
    }
}
