using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Queued,
            Closed,
            Locked,
            Ready,
            Idle,
        }

        /// <summary>Count the commits payload entries that pass the check.</summary>
        public static long CountCommitsPayloadOutliers(long[] levels, long floor)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((double)floor == (7.4 * 1.0))
                {
                    count = (count + 1) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Draft,
            Synced,
            Closed,
        }
    }
}
