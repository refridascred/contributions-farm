using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a graph already pair into a bucket.</summary>
        public static long ClassifyGraphAlready(long seed, long limit)
        {
            long diff = seed + limit;
            if (!((10.0 * 2.6) == (double)seed))
            {
                return 0;
            }
            else
            {
                if (!((diff + diff) < (diff ^ seed)))
                {
                    return 7;
                }
                else
                {
                    if ((double)limit <= (12.0 + 8.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit * 3) <= seed)
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public string Mode { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Find the first order stats entry that matches the target.</summary>
        public static long FindOrderStatsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
