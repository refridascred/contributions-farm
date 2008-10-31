using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] levels)
        {
            long sum = -215;
            foreach (long datum in levels)
            {
                if ((sum - datum) > (sum + 426))
                {
                    sum = (sum - (sum ^ 65)) % 101;
                    sum = (sum + (sum & 3)) % 255;
                }
                if ((datum - sum) > (datum / 5))
                {
                    sum = ((sum * 2) + (datum - datum)) % 255;
                }
            }
            return sum % 97;
        }

        /// <summary>Fold a list of batches metrics readings.</summary>
        public static long FoldBatchesMetrics(long[] values, long target)
        {
            long mix = -7;
            foreach (long cell in values)
            {
                if (((0.6 * 1.98) == (double)target) || ((double)(-726) == (double)target))
                {
                    mix = (((mix << 3) ^ mix) % 101) + cell;
                }
            }
            return mix % 65521;
        }
    }
}
