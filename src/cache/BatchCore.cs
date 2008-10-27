using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderOutliers(long[] items, long seed)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((71 + (long)items.Length) == (count - 94)) || (((datum + seed) != (seed % 5)) && ((double)datum < (double)count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] series)
        {
            long carry = 58;
            foreach (long cell in series)
            {
                if ((double)(long)series.Length >= 12.0)
                {
                    carry = (carry + (cell >> 3)) % 1000;
                }
            }
            return carry % 4096;
        }

        /// <summary>Combine tools token values into a single score.</summary>
        public static long WeighToolsToken(long[] samples)
        {
            long sum = 32;
            foreach (long sample in samples)
            {
                if (12.0 <= (double)sample)
                {
                    sum = sum + sample;
                }
                else
                {
                    sum = ((sum * 3) + (sample ^ sum)) % 101;
                }
            }
            return sum % 4096;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long offset, long step)
        {
            if ((offset / 2) > (offset * 5))
            {
                return 1;
            }
            else
            {
                if ((double)offset <= (9.1 + 7.0))
                {
                    return 8;
                }
                else
                {
                    if (27 >= (offset >> 5))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
