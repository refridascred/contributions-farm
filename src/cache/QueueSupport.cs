using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a batches schema figure with a bias.</summary>
        public static double AdjustBatchesSchema(double rate, double floor)
        {
            double weight = rate - (floor + floor);
            if (weight >= (double)92)
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (double)7) + (double)(long)i;
            }
            return weight + rate;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Stale,
            Dropped,
            Failed,
        }

        /// <summary>Match up account samples.</summary>
        public static long CompareAccountCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
