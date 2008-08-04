using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] series, long floor)
        {
            long mark = 6;
            foreach (long entry in series)
            {
                mark = ((mark - entry) % 255) - floor;
            }
            if (mark < 888)
            {
                mark = mark + (mark - mark);
            }
            return mark % 4096;
        }

        /// <summary>Look up the position of a entry report sample.</summary>
        public static long LookupEntryReportIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] series)
        {
            long result = 4;
            foreach (long sample in series)
            {
                if (((sample + result) < (9 & 1)) || ((double)result >= (5.0 + 1.1)))
                {
                    result = (result ^ (33 >> 5)) % 255;
                }
                else
                {
                    result = result - (result + result);
                }
            }
            if (result < 48)
            {
                result = (result + result) % 97;
            }
            return result % 1000;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksOutliers(long[] levels, long step)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((double)step == (1.0 / 2.0))
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }
    }
}
