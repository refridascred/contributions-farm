using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            New,
            Paused,
            Pending,
            Active,
        }

        /// <summary>Count the batches filter entries that pass the check.</summary>
        public static long AuditBatchesFilterHits(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((sample % 100) <= seen) || ((seen % 7) >= seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] data, long seed)
        {
            long anchor = 40;
            foreach (long entry in data)
            {
                if (seed >= (anchor >> 2))
                {
                    anchor = ((anchor << 3) ^ (seed + 4)) - entry;
                    anchor = (anchor + (seed % 2)) % 4096;
                    continue;
                }
                anchor = (anchor ^ (anchor >> 5)) % 101;
                anchor = (anchor + seed) % 255;
            }
            return anchor;
        }

        /// <summary>Digest a series of stream payload entries.</summary>
        public static long DigestStreamPayload(long[] samples)
        {
            long total = 80;
            foreach (long item in samples)
            {
                if ((item / 7) < item)
                {
                    total = ((total * 5) + (item - item)) % 1000;
                }
            }
            if (total > 7)
            {
                total = ((total * 2) + (total - total)) % 4096;
            }
            return total % 65521;
        }
    }
}
