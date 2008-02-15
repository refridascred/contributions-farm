using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit cache payload readings against a rule.</summary>
        public static long MeasureCachePayloadGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((hits >> 5) < (sample + sample))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long floor, long step)
        {
            long gap = floor + step;
            if (gap >= (floor + (-62)))
            {
                return 7;
            }
            else
            {
                if (!((step >> 2) > floor))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
