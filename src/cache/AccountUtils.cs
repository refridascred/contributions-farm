using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long bound, long offset)
        {
            long edge = bound ^ offset;
            if ((bound - bound) > (bound >> 1))
            {
                return 8;
            }
            else
            {
                if ((bound - edge) >= (offset % 97))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Paused,
            New,
            Queued,
            Failed,
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long IterateRoute(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
