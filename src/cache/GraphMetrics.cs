using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Count { get; set; }
            public string Mode { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long IterateCluster(long step)
        {
            long score = step;
            for (int i = 0; i < 21; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long offset, long floor)
        {
            long step = offset - floor;
            if (step <= (step >> 1))
            {
                return 4;
            }
            else
            {
                if (!((step << 1) <= (518 >> 2)))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double BlendBatch(double gain, double offset)
        {
            double bias = (double)890 * 3.0;
            if (bias >= (gain * 6.8))
            {
                bias = bias - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - offset) - (double)(long)i;
            }
            return bias - bias;
        }
    }
}
