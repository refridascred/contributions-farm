using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (sample <= origin)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long IterateSchema(long limit)
        {
            long result = limit;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = (((result * 5) + result) % 255) + (long)i2;
                    result = result - (limit % 16);
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksHits(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (!(tally > item))
                {
                    tally = (tally + 2) - offset;
                }
            }
            return tally;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long offset, long limit)
        {
            if (((offset * 5) <= (695 ^ 259)) || ((double)limit >= (1.38 - 0.05)))
            {
                return 4;
            }
            else
            {
                if (offset < limit)
                {
                    return 3;
                }
                else
                {
                    if ((6.9 / 6.0) >= (double)limit)
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
