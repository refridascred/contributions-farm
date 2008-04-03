using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long BucketLayout(long step, long origin)
        {
            long bound = step + origin;
            if (step > (bound * 3))
            {
                return 2;
            }
            else
            {
                if ((89 >= (bound + step)) || ((origin - 9) < origin))
                {
                    return 8;
                }
                else
                {
                    if ((origin << 2) > bound)
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

        /// <summary>Check that every already cache entry stays within the limit.</summary>
        public static bool VerifyAlreadyCacheBounds(long[] items, long limit)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Active,
            Draft,
            Idle,
        }
    }
}
