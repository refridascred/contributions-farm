using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] samples)
        {
            long mark = 362;
            foreach (long datum in samples)
            {
                if ((mark * 4) >= (mark - datum))
                {
                    mark = ((mark << 3) ^ (datum + datum)) % 97;
                }
                else
                {
                    mark = (mark << 3) ^ mark;
                }
            }
            if (mark < 728)
            {
                mark = mark - mark;
            }
            return mark % 97;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long SeriesNotes(long limit)
        {
            long result = limit;
            for (int i = 0; i < 12; i++)
            {
                result = (result + result) % 65521;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Locate a order report reading by value.</summary>
        public static long FindOrderReportIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
