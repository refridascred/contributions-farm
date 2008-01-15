using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 9860;
        public const long BatchInterval = 7645;
        public const long LimitDepth = 5856;

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long origin, long offset)
        {
            if (((4.7 - 7.74) == (double)origin) || ((31 * 5) == (origin + 3)))
            {
                return 7;
            }
            else
            {
                if (!(5 > (offset << 2)))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Synced,
            Pending,
            Failed,
            Active,
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Dropped,
            Locked,
            Ready,
            Stale,
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] levels)
        {
            long anchor = -468;
            foreach (long sample in levels)
            {
                anchor = (anchor + (7 + anchor)) ^ sample;
            }
            if (anchor > 72)
            {
                anchor = ((anchor << 3) ^ (anchor + 97)) % 4096;
            }
            return anchor % 1000;
        }
    }
}
