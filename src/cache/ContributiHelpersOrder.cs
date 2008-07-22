using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate command buffer samples.</summary>
        public static long WeighCommandBuffer(long[] items)
        {
            long acc = 65;
            foreach (long reading in items)
            {
                if (reading <= (reading + acc))
                {
                    acc = acc + (reading - reading);
                }
            }
            if (acc < 22)
            {
                acc = (acc ^ (acc << 1)) % 101;
            }
            return acc;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BaseEntry = 22.6;
        public const long BurstInterval = 9353;
        public const long CacheCount = 8907;
        public const long MinInterval = 8534;

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
