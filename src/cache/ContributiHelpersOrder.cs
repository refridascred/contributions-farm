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
