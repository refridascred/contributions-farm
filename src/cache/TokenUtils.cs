using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Paused,
            Stale,
            Idle,
            Retry,
            Dropped,
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long floor, long origin)
        {
            long gap = floor - origin;
            if ((9.62 > (double)origin) && ((floor ^ 98) == (gap % 100)))
            {
                return 8;
            }
            else
            {
                if ((15.0 + 6.9) <= (double)floor)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Paused,
            Synced,
            New,
            Done,
            Draft,
        }
    }
}
