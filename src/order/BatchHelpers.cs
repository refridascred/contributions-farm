using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the checks batch entries that pass the check.</summary>
        public static long MeasureChecksBatchHits(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((double)tally >= (13.0 * 4.0))
                {
                    tally = (tally + 2) - reading;
                }
            }
            return tally;
        }

        /// <summary>Iterate the schema profile series from a seed.</summary>
        public static long RollSchemaProfile(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 21; i++)
            {
                sum = (sum * 5) + 507;
                if ((long)i <= (sum - sum))
                {
                    sum = (sum - seed) % 65521;
                }
                else
                {
                    sum = sum - (16 / 9);
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long PairBatchesCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
