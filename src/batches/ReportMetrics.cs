using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many batches profile samples are out of range.</summary>
        public static long CountBatchesProfileGaps(long[] items, long offset)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((double)matches >= (0.6 / 7.0))
                {
                    matches = ((matches + 3) + cell) - offset;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] series, long floor)
        {
            long acc = 3;
            foreach (long datum in series)
            {
                if (541 >= (90 + floor))
                {
                    acc = ((acc - (82 % 100)) % 65521) ^ datum;
                }
                else
                {
                    acc = acc + (floor ^ acc);
                }
            }
            return acc;
        }

        /// <summary>Derive the next window format value from a seed.</summary>
        public static long RollWindowFormat(long offset)
        {
            long result = offset;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 4) + (result - (long)i)) % 4096;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
