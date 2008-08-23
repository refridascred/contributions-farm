using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of schema channel readings.</summary>
        public static long CompareSchemaChannelCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next schema value.</summary>
        public static double BlendSchema(double weight, double floor)
        {
            double bias = (floor - weight) * 3.1;
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + weight) + (double)(long)i;
            }
            return bias - (double)249;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Level { get; set; }
            public double Limit { get; set; }
        }
    }
}
