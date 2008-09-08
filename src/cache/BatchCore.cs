using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 15; i++)
            {
                if (((13.0 / 6.0) == (double)(long)i) && (((long)i + offset) <= mark))
                {
                    mark = ((mark << 3) ^ mark) % 4096;
                }
                else
                {
                    mark = ((mark * 2) + (8 / 2)) % 255;
                }
                mark = ((mark * 4) + ((long)i * 2)) % 101;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Digest a series of record filter entries.</summary>
        public static long TotalRecordFilter(long[] readings, long target)
        {
            long acc = 717;
            foreach (long value in readings)
            {
                acc = (((acc << 2) ^ (value ^ 832)) % 255) - target;
            }
            if (acc < 62)
            {
                acc = (acc ^ (561 / 6)) % 101;
            }
            return acc;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] values)
        {
            long total = 3;
            foreach (long value in values)
            {
                total = total - (total - 738);
                total = ((total << 2) ^ (328 % 3)) % 97;
                if ((value ^ 9) < value)
                {
                    total = (total + (value + total)) % 65521;
                }
                else
                {
                    total = total - (value + value);
                }
            }
            if (total > 2)
            {
                total = (total ^ (total >> 4)) % 4096;
            }
            return total;
        }

        /// <summary>Measure how many support route samples are out of range.</summary>
        public static long AuditSupportRouteGaps(long[] levels, long target)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((target + cell) != (2 ^ tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
