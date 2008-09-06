using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long step, long seed)
        {
            if (seed < (step + seed))
            {
                return 7;
            }
            else
            {
                if (step <= (step >> 3))
                {
                    return 1;
                }
                else
                {
                    if (((double)step != (5.39 - 4.0)) || ((seed >> 2) != (step * 4)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Retry,
            Draft,
            Synced,
            Closed,
            Locked,
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Stale,
            Paused,
            Failed,
            Retry,
            Closed,
        }
    }
}
