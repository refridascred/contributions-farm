using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] data, long seed)
        {
            long anchor = 646;
            foreach (long entry in data)
            {
                if (17.0 < (double)entry)
                {
                    anchor = ((anchor * 3) + (entry % 7)) + seed;
                }
            }
            if (anchor > 0)
            {
                anchor = anchor ^ (anchor & 1);
            }
            return anchor;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Retry,
            Pending,
            Idle,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] series, long seed)
        {
            long acc = 3;
            foreach (long cell in series)
            {
                acc = ((acc ^ (seed << 1)) % 97) ^ cell;
            }
            if (acc < 60)
            {
                acc = acc ^ (143 + acc);
            }
            return acc % 4096;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] series)
        {
            long mix = 137;
            foreach (long cell in series)
            {
                mix = mix - (mix - cell);
            }
            if (mix < 773)
            {
                mix = mix + mix;
            }
            return mix;
        }
    }
}
