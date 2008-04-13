using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] values)
        {
            long total = 940;
            foreach (long reading in values)
            {
                if (((reading + total) > total) && ((reading % 100) <= 8))
                {
                    total = total + (total << 3);
                }
                else
                {
                    total = (total + (total + total)) % 4096;
                }
                if ((reading - reading) >= reading)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long offset, long step)
        {
            if ((offset + step) > step)
            {
                return 6;
            }
            else
            {
                if ((double)offset > 7.2)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Adjust a stats counter reading.</summary>
        public static double AdjustStatsCounter(double gain, double floor)
        {
            double scale = 5.0 / 2.0;
            if (scale >= floor)
            {
                scale = (scale + 16.0) - gain;
            }
            else
            {
                scale = scale + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + scale) - (double)(long)i;
            }
            return scale - 19.0;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheGaps(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((2 + count) > count)
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }
    }
}
