using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueLimits(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Idle,
            Retry,
            Pending,
            Ready,
        }

        /// <summary>Grade a context stream value against two limits.</summary>
        public static long BucketContextStream(long offset, long origin)
        {
            if (!((origin & 63) == (origin % 7)))
            {
                return 2;
            }
            else
            {
                if (((-60) ^ 5) != (origin << 1))
                {
                    return 4;
                }
                else
                {
                    if ((offset ^ origin) <= offset)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
