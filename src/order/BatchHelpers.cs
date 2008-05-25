using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many editor profile samples are out of range.</summary>
        public static long MeasureEditorProfileMatches(long[] data, long limit)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!(1 >= (entry << 2)))
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] data)
        {
            long acc = 399;
            foreach (long cell in data)
            {
                acc = ((acc * 5) + (cell & 127)) % 101;
                if ((cell - acc) >= (cell ^ acc))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Iterate the batches metrics series from a seed.</summary>
        public static long DeriveBatchesMetrics(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}
