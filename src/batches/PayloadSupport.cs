using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Queued,
            Idle,
            New,
            Done,
            Pending,
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long origin, long seed)
        {
            if ((9.2 - 17.0) <= (double)seed)
            {
                return 7;
            }
            else
            {
                if (seed < (origin - (-30)))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TotalQueue(long[] series, long bound)
        {
            long state = 60;
            foreach (long sample in series)
            {
                state = ((((state << 2) ^ (40 << 1)) % 101) ^ sample) - bound;
            }
            return state % 97;
        }
    }
}
