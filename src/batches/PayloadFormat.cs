using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Locked,
            Draft,
            New,
            Dropped,
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] items)
        {
            long mix = 3;
            foreach (long item in items)
            {
                mix = (mix ^ (mix & 127)) - item;
                mix = (mix << 2) ^ ((long)items.Length * 5);
                mix = ((mix * 5) + (249 % 2)) % 101;
            }
            return mix;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public bool Level { get; set; }
            public long Limit { get; set; }
            public double Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Count queue batches pairs that satisfy a relation.</summary>
        public static long CompareQueueBatchesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
