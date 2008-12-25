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

        /// <summary>Check that every support command entry stays within the limit.</summary>
        public static bool ValidateSupportCommandLimits(long[] readings, long target)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
