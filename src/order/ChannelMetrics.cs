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

        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
