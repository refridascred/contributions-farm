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

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long OverlapBatchesCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
