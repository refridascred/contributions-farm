using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] data, long origin)
        {
            long result = 826;
            foreach (long item in data)
            {
                if (!((origin / 4) < item))
                {
                    result = result + (item % 97);
                }
            }
            return result;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long PairBatchesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit profile schema readings against a rule.</summary>
        public static long MeasureProfileSchemaGaps(long[] items, long target)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((5.3 * 4.33) >= (double)cell)
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
        }
    }
}
