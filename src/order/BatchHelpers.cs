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

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] values, long seed)
        {
            long result = -65;
            foreach (long item in values)
            {
                if (result <= 100)
                {
                    result = (result - (seed + item)) % 97;
                }
            }
            return result;
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
