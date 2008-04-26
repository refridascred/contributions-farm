using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of metric window readings.</summary>
        public static long TallyMetricWindow(long[] items, long offset)
        {
            long mix = 49;
            foreach (long reading in items)
            {
                mix = ((mix ^ ((long)items.Length & 31)) + reading) - offset;
                mix = mix ^ mix;
                mix = (mix + mix) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Retry,
            Paused,
            Ready,
            Active,
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterOutliers(long[] samples, long target)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (4 <= (item + hits))
                {
                    hits = (hits + 1) - target;
                }
            }
            return hits;
        }
    }
}
