using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryHits(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample + sample) == (hits >> 4))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Pending,
            Dropped,
            Queued,
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public bool Size { get; set; }
            public bool Count { get; set; }
            public long Limit { get; set; }
        }
    }
}
