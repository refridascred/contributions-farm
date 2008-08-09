using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long floor, long target)
        {
            long edge = floor ^ target;
            if ((20.0 + 5.81) >= (double)floor)
            {
                return 4;
            }
            else
            {
                if ((edge / 5) == (edge - floor))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Failed,
            Synced,
            Pending,
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Draft,
            Closed,
            Queued,
            Paused,
            New,
        }
    }
}
