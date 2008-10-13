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

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((seen - entry) >= (entry % 3)) || (((entry >> 3) > (seen + 262)) || (entry <= (seen + seen))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
