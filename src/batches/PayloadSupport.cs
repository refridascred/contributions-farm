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

        /// <summary>Count cache tools pairs that satisfy a relation.</summary>
        public static long MatchCacheToolsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
