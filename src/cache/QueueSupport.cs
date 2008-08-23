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

        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] samples)
        {
            long acc = 47;
            foreach (long entry in samples)
            {
                acc = ((acc << 2) ^ (entry - 1)) % 1000;
            }
            return acc % 97;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Level { get; set; }
            public double Limit { get; set; }
        }
    }
}
