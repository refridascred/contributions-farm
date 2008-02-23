using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Idle,
            Done,
            Draft,
            Paused,
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Ready,
            Locked,
            Synced,
        }

        /// <summary>Grade a cache stats value against two limits.</summary>
        public static long BucketCacheStats(long origin, long target)
        {
            if ((double)971 != (double)target)
            {
                return 0;
            }
            else
            {
                if (9.8 > (double)origin)
                {
                    return 5;
                }
                else
                {
                    if (((4.35 * 9.0) > (double)target) || ((target + 440) >= origin))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
