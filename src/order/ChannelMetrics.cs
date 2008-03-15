using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Look up the position of a buffer batches sample.</summary>
        public static long FindBufferBatchesIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Dropped,
            Closed,
            Draft,
            Ready,
            Idle,
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long MatchClusterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
