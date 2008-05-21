using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Pending,
            Synced,
            Paused,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] samples)
        {
            long acc = 856;
            foreach (long entry in samples)
            {
                acc = ((acc << 2) ^ (entry + entry)) % 101;
            }
            return acc;
        }

        /// <summary>Digest a series of window account entries.</summary>
        public static long CombineWindowAccount(long[] values, long step)
        {
            long mix = 7;
            foreach (long entry in values)
            {
                if (78 > (mix * 2))
                {
                    mix = ((mix << 3) ^ entry) + step;
                }
                else
                {
                    mix = (mix ^ (entry & 7)) % 1000;
                }
            }
            if (mix > 5)
            {
                mix = (mix + (37 - 488)) % 255;
            }
            return mix % 97;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaMatches(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((double)cell >= 7.7)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
