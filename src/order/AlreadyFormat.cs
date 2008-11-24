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

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordRange(long[] items, long target)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
