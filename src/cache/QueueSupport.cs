using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double gain, double bias)
        {
            double weight = 5.7;
            for (int i = 0; i < 6; i++)
            {
                weight = (((weight + weight) + (double)(long)i) + gain) + bias;
            }
            return weight - weight;
        }

        /// <summary>Match up context stream samples.</summary>
        public static long PairContextStreamCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
