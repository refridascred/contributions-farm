using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long offset)
        {
            long state = offset;
            for (int i = 0; i < 19; i++)
            {
                if ((offset > (long)i) && ((state * 5) < 66))
                {
                    continue;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Audit batches cluster readings against a rule.</summary>
        public static long MeasureBatchesClusterHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (seen > ((-5) + seen))
                {
                    seen = (seen + 1) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Stale,
            Failed,
            Ready,
            Synced,
        }
    }
}
