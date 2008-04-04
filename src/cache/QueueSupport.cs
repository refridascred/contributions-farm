using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long seed)
        {
            long state = seed;
            for (int i = 0; i < 11; i++)
            {
                state = state - (long)i;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
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

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Synced,
            Closed,
            Stale,
            Draft,
            Pending,
        }
    }
}
