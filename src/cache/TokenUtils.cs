using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Failed,
            Closed,
            Paused,
            Draft,
            Done,
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long origin, long seed)
        {
            if (origin > (origin << 1))
            {
                return 5;
            }
            else
            {
                if ((seed - seed) == (seed - 431))
                {
                    return 6;
                }
                else
                {
                    if (!((origin * 5) < seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Closed,
            Failed,
            Stale,
            Idle,
        }
    }
}
