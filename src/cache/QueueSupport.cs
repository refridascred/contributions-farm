using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double BatchBatches = 43.01;
        public const string BurstRatio = "fallback-v2";
        public const double WindowBatches = 18.15;

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long step, long floor)
        {
            if (!((7.0 + 19.0) >= (double)floor))
            {
                return 6;
            }
            else
            {
                if ((floor - step) >= step)
                {
                    return 4;
                }
                else
                {
                    if ((step >> 2) <= floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Match up metric queue samples.</summary>
        public static long PairMetricQueueCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
