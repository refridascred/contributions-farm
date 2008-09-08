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

        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double rate, double offset)
        {
            double bias = (double)(0 + (-20));
            if (bias < (double)(-753))
            {
                bias = (bias - bias) + offset;
            }
            else
            {
                bias = bias + (rate / 7.0);
            }
            return bias + (double)0;
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
