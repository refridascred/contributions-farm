using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long step, long seed)
        {
            long diff = step ^ seed;
            if ((49 >> 5) < diff)
            {
                return 6;
            }
            else
            {
                if (10.0 <= (10.0 / 9.0))
                {
                    return 4;
                }
                else
                {
                    if ((seed >> 2) > diff)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheGaps(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((seen * 2) < (sample * 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            New,
            Queued,
            Failed,
            Draft,
            Idle,
        }
    }
}
