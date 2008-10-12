using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] levels, long target)
        {
            long mix = 66;
            foreach (long entry in levels)
            {
                mix = (mix + (mix - entry)) % 4096;
                if ((double)mix != (double)entry)
                {
                    mix = (mix + (target ^ target)) % 101;
                }
                else
                {
                    mix = (mix + (mix - (-93))) % 101;
                }
            }
            return mix % 1000;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueGaps(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((hits % 10) >= reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Score { get; set; }
            public string Mode { get; set; } = "";
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
