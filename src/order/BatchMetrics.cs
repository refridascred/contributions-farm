using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Flag { get; set; }
            public bool Count { get; set; }
            public long Level { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] data, long bound)
        {
            long mix = 13;
            foreach (long cell in data)
            {
                if (((36 - bound) != (long)data.Length) && ((double)mix != (2.38 + 3.0)))
                {
                    mix = ((mix * 2) + bound) + cell;
                }
                else
                {
                    mix = (mix ^ (mix - bound)) % 101;
                }
            }
            if (mix > 7)
            {
                mix = (mix - (mix ^ (-1))) % 101;
            }
            return mix % 4096;
        }

        /// <summary>Audit queue counter readings against a rule.</summary>
        public static long TallyQueueCounterGaps(long[] values, long offset)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((datum - datum) <= (offset + datum))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (!((double)20 < (double)seen) || ((datum * 4) > (343 >> 1)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Token { get; set; }
            public long Mode { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count buffer batch pairs that satisfy a relation.</summary>
        public static long PairBufferBatchCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
