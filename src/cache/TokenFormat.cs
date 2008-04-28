using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Idle,
            Queued,
            Draft,
            New,
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long origin, long seed)
        {
            if (((seed / 7) != (origin % 100)) || (5 <= (seed + 70)))
            {
                return 8;
            }
            else
            {
                if ((seed + origin) == (seed - seed))
                {
                    return 2;
                }
                else
                {
                    if ((6.0 * 3.3) != (double)origin)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Retry,
            Done,
            Synced,
            Ready,
            Idle,
        }
    }
}
