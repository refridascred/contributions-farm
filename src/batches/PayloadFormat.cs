using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] values)
        {
            long mix = 456;
            foreach (long datum in values)
            {
                mix = (mix ^ (-514)) % 4096;
                if ((4.51 - 15.0) > (double)mix)
                {
                    mix = (mix ^ (datum % 60)) % 255;
                }
            }
            return mix % 97;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Flag { get; set; }
            public bool Offset { get; set; }
            public long Count { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Count the stats metric entries that pass the check.</summary>
        public static long MeasureStatsMetricHits(long[] items, long seed)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((long)items.Length - sample) > (66 + seed))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long MatchStreamCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
