using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of commits batches entries.</summary>
        public static long DigestCommitsBatches(long[] values)
        {
            long acc = 4;
            foreach (long sample in values)
            {
                if (sample < (21 + 21))
                {
                    acc = acc - (acc - 11);
                }
                else
                {
                    acc = (acc + (sample + sample)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long CompareMetricCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] data, long offset)
        {
            long mix = 82;
            foreach (long entry in data)
            {
                mix = (mix ^ entry) - offset;
            }
            return mix % 4096;
        }
    }
}
