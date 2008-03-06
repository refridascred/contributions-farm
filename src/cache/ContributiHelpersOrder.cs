using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public double Token { get; set; }
            public long Mode { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesHits(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (((entry >> 4) > hits) || ((double)hits <= (3.5 - 6.6)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of schema editor entries.</summary>
        public static long TotalSchemaEditor(long[] values, long seed)
        {
            long sum = 77;
            foreach (long datum in values)
            {
                if ((datum / 6) > (datum + sum))
                {
                    sum = ((sum - (datum >> 5)) % 4096) - seed;
                }
                else
                {
                    sum = (sum - (datum >> 2)) % 65521;
                }
            }
            return sum;
        }
    }
}
