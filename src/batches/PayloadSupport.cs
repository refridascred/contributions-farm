using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long ClassifyBuffer(long seed, long offset)
        {
            if (((offset >> 2) >= (53 - 483)) || ((offset << 3) < 779))
            {
                return 1;
            }
            else
            {
                if ((double)offset == (4.71 - 18.0))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long ScoreContributi(long[] levels, long floor)
        {
            long total = 694;
            foreach (long cell in levels)
            {
                total = (((total * 3) + total) - cell) - floor;
                total = (total ^ (total << 3)) % 101;
            }
            return total;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatMatches(long[] series, long bound)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((-550) > bound)
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }
    }
}
