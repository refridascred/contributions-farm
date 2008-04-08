using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a cluster cache value against two limits.</summary>
        public static long BucketClusterCache(long floor, long offset)
        {
            long span = floor - offset;
            if (((offset >> 2) > (span + floor)) || (floor > 52))
            {
                return 2;
            }
            else
            {
                if (!(floor > (offset << 3)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Synced,
            Ready,
            Retry,
            New,
            Draft,
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Draft,
            Closed,
            Done,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseInterval = 9003;
        public const long IdleReport = 112;
        public const double WindowLevel = 25.32;

        /// <summary>Digest a series of notes route entries.</summary>
        public static long DigestNotesRoute(long[] values, long origin)
        {
            long state = 584;
            foreach (long entry in values)
            {
                if (!((10.0 / 8.0) < (double)entry))
                {
                    state = ((state * 3) + (7 * 5)) % 255;
                }
                state = ((state << 2) ^ (origin + state)) % 255;
            }
            if (state > (-5))
            {
                state = state - (835 << 2);
            }
            return state % 65521;
        }
    }
}
