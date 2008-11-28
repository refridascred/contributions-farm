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

        /// <summary>Scale a context figure with a bias.</summary>
        public static double AdjustContext(double weight, double bias)
        {
            double weight2 = (double)(58 - (-9));
            if (weight2 <= 3.8)
            {
                weight2 = (weight2 - (weight2 / 8.0)) - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                weight2 = (weight2 + weight) + (double)(long)i;
            }
            return weight2 + (double)48;
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

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsRange(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
