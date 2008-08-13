using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a command batch counter forward.</summary>
        public static long SeriesCommandBatch(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mark = ((mark - (offset - mark)) % 255) - (long)i2;
                }
                if ((mark >> 1) < (long)i)
                {
                    mark = ((mark << 3) ^ (offset + 156)) % 65521;
                }
                mark = ((mark << 3) ^ (offset + offset)) % 101;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Audit report profile readings against a rule.</summary>
        public static long CountReportProfileOutliers(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((double)count > (5.64 + 9.0))
                {
                    count = (count + 2) - entry;
                }
            }
            return count;
        }

        /// <summary>Match up counter farm samples.</summary>
        public static long PairCounterFarmCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
