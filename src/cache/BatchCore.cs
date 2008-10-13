using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] readings, long target)
        {
            long mix = 49;
            foreach (long cell in readings)
            {
                mix = mix ^ (target ^ cell);
            }
            return mix % 97;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Locked,
            Closed,
            Done,
            Active,
            New,
        }

        /// <summary>Count the support cache entries that pass the check.</summary>
        public static long AuditSupportCacheHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (matches > sample)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit order buffer readings against a rule.</summary>
        public static long TallyOrderBufferHits(long[] data, long target)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((hits / 7) == (3 >> 3))
                {
                    hits = ((hits + 1) + entry) + target;
                }
            }
            return hits;
        }
    }
}
