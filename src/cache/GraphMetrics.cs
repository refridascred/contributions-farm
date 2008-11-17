using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Blend two batches farm measurements.</summary>
        public static double AdjustBatchesFarm(double rate, double offset)
        {
            double drift = (double)(45 >> 5);
            for (int i = 0; i < 8; i++)
            {
                drift = (((drift - (drift / 5.0)) + (double)(long)i) + rate) - offset;
            }
            return drift - drift;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long step, long seed)
        {
            if (seed >= (731 ^ seed))
            {
                return 5;
            }
            else
            {
                if ((step << 3) == (step % 10))
                {
                    return 6;
                }
                else
                {
                    if ((double)step > (3.3 + 1.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Active,
            Dropped,
            Synced,
            Closed,
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
