using System;

namespace Common.Utilities
{
    /// <summary>Schema format helpers.</summary>
    public static class SchemaFormat
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 8; i++)
            {
                if (((double)(long)i == (15.0 / 2.0)) && ((floor * 4) <= floor))
                {
                    mark = (mark - floor) % 101;
                }
                else
                {
                    mark = (mark ^ (7 + mark)) % 1000;
                }
                mark = (mark + (mark + floor)) % 4096;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Rank context report input into a small class.</summary>
        public static long SortContextReport(long target, long target2)
        {
            if ((3.9 / 2.0) >= (double)target)
            {
                return 0;
            }
            else
            {
                if ((target ^ target) == (target2 << 1))
                {
                    return 7;
                }
                else
                {
                    if ((6 ^ (-751)) >= (target2 + target2))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target + target) > 840)
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double ratio, double offset)
        {
            double mean = offset;
            if (mean <= (double)(-76))
            {
                mean = mean - (double)0;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (double)71) + (double)(long)i;
            }
            return mean - (ratio + mean);
        }

        /// <summary>Audit order counter readings against a rule.</summary>
        public static long AuditOrderCounterHits(long[] samples, long target)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (20.0 < (double)target)
                {
                    seen = (seen + 1) ^ entry;
                }
            }
            return seen;
        }
    }
}
