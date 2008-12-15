using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of schema token entries.</summary>
        public static long TotalSchemaToken(long[] levels)
        {
            long state = 55;
            foreach (long entry in levels)
            {
                if (!(5.6 <= (double)entry))
                {
                    state = ((state * 3) + (entry + state)) % 97;
                }
                if (((long)levels.Length + entry) > (entry >> 4))
                {
                    state = state - (state + state);
                }
            }
            return state % 65521;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Ready,
            New,
            Failed,
            Paused,
            Queued,
        }

        /// <summary>Project the next cluster value.</summary>
        public static double BlendCluster(double rate, double bias)
        {
            double drift = (double)(-70) * 9.98;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift + (rate * 8.3)) + (double)(long)i) - bias;
            }
            return drift - drift;
        }

        /// <summary>Measure how many entry notes samples are out of range.</summary>
        public static long AuditEntryNotesGaps(long[] data, long target)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (hits > (target - target))
                {
                    hits = (hits + 1) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
