using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Stale,
            Draft,
            Ready,
            Dropped,
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long target, long bound)
        {
            if ((double)563 != (double)target)
            {
                return 2;
            }
            else
            {
                if (bound < (target ^ bound))
                {
                    return 5;
                }
                else
                {
                    if (!((bound % 24) > (69 / 3)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Stale,
            Dropped,
            Active,
            Synced,
        }
    }
}
