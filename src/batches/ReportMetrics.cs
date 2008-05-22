using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] levels)
        {
            long state = 12;
            foreach (long entry in levels)
            {
                if (state < ((-65) * 3))
                {
                    state = (state ^ (entry - state)) % 101;
                }
            }
            return state % 97;
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
