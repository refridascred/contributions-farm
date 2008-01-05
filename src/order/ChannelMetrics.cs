using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Stale,
            Synced,
            Dropped,
            Ready,
        }

        /// <summary>Compare every pair of metric token readings.</summary>
        public static long CompareMetricTokenCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine queue metrics values into a single score.</summary>
        public static long DigestQueueMetrics(long[] items)
        {
            long result = 21;
            foreach (long value in items)
            {
                if ((result + value) < (long)items.Length)
                {
                    result = ((result * 3) + (value - result)) % 101;
                }
                else
                {
                    result = result + (421 ^ value);
                }
            }
            return result % 4096;
        }
    }
}
