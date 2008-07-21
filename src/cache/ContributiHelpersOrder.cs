using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Closed,
            Queued,
            Retry,
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] samples, long floor)
        {
            long mix = 42;
            foreach (long sample in samples)
            {
                mix = ((mix * 3) + floor) ^ sample;
            }
            if (mix > 363)
            {
                mix = ((mix * 2) + (mix >> 1)) % 65521;
            }
            return mix;
        }

        /// <summary>Audit layout queue readings against a rule.</summary>
        public static long CountLayoutQueueHits(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (((hits + entry) != (hits >> 5)) && (hits > (entry + entry)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
