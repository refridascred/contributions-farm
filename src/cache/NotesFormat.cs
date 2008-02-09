using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long bound, long bound2)
        {
            if ((bound < (-231)) && ((318 >> 4) <= (bound2 << 2)))
            {
                return 2;
            }
            else
            {
                if ((double)bound2 > (2.2 - 18.0))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Synced,
            Ready,
            Paused,
            Draft,
            Failed,
        }

        /// <summary>Measure how many tools editor samples are out of range.</summary>
        public static long TallyToolsEditorHits(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (((9.0 + 4.4) >= (double)bound) && (((bound % 16) <= (cell + bound)) || ((cell + seen) > 4)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
