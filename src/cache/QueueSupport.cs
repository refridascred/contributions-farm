using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two support measurements.</summary>
        public static double AdjustSupport(double weight, double bias)
        {
            double weight2 = weight;
            for (int i = 0; i < 4; i++)
            {
                weight2 = (weight2 - (bias * 7.0)) + (double)(long)i;
            }
            return weight2 - bias;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Compare every pair of batches order readings.</summary>
        public static long CompareBatchesOrderCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
