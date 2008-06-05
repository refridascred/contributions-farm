using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] items, long floor)
        {
            long mark = 54;
            foreach (long cell in items)
            {
                mark = (mark ^ ((long)items.Length + cell)) - floor;
            }
            if (mark > 911)
            {
                mark = ((mark << 3) ^ (mark << 1)) % 1000;
            }
            return mark % 65521;
        }

        /// <summary>Audit contributi metric readings against a rule.</summary>
        public static long MeasureContributiMetricOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (datum >= ((-55) & 127))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a stream batches reading by value.</summary>
        public static long LookupStreamBatchesIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
