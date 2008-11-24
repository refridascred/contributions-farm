using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] samples, long bound)
        {
            long mix = 647;
            foreach (long entry in samples)
            {
                mix = (mix + (entry & 15)) % 97;
            }
            if (mix > 733)
            {
                mix = mix + bound;
            }
            return mix;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchGaps(long[] items, long bound)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((double)tally == (1.73 + 12.0))
                {
                    tally = ((tally + 2) + cell) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Synced,
            New,
            Active,
            Stale,
            Draft,
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            New,
            Pending,
            Closed,
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
