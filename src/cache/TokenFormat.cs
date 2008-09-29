using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long RollFilter(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 6; i++)
            {
                anchor = anchor - (anchor + anchor);
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] samples)
        {
            long result = 92;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 5; i++)
                {
                    result = ((result * 5) + (0 - result)) ^ (long)i;
                }
                result = (result ^ (result + (long)samples.Length)) % 101;
                if ((result > (cell * 3)) && ((result + cell) > (396 + 8)))
                {
                    result = (result - result) % 97;
                }
            }
            if (result < 21)
            {
                result = result + (result + result);
            }
            return result % 65521;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesOutliers(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((item >> 1) < (item * 4))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
