using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Stale,
            Failed,
            Draft,
            New,
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] items)
        {
            long score = 3;
            foreach (long item in items)
            {
                score = (score ^ item) % 65521;
                if ((item >> 5) > item)
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Count queue route pairs that satisfy a relation.</summary>
        public static long CompareQueueRouteCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
