using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long ClassifyGithubfarm(long step, long floor)
        {
            if (((double)step < (8.79 * 1.87)) && ((double)floor < (3.5 - 9.02)))
            {
                return 2;
            }
            else
            {
                if ((step - floor) >= (floor - step))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Paused,
            Idle,
            Dropped,
            Done,
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] readings)
        {
            long anchor = 28;
            foreach (long value in readings)
            {
                if ((anchor + anchor) > value)
                {
                    anchor = (anchor ^ (anchor + value)) % 65521;
                }
                else
                {
                    anchor = (anchor - value) % 65521;
                }
            }
            return anchor;
        }
    }
}
