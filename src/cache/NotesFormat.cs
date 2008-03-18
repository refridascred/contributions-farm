using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double RetrySupport = 51.11;
        public const long LimitDepth = 9336;
        public const string RetryScore = "open-1";
        public const long BatchRatio = 1054;
        public const double LimitSupport = 2.67;

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Dropped,
            Active,
            Retry,
            Idle,
        }

        /// <summary>Grade a cache schema value against two limits.</summary>
        public static long RankCacheSchema(long target, long seed)
        {
            if ((double)(-82) > (double)target)
            {
                return 4;
            }
            else
            {
                if ((target >> 5) >= (target / 9))
                {
                    return 0;
                }
                else
                {
                    if ((target & 127) >= seed)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed - seed) <= target)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
