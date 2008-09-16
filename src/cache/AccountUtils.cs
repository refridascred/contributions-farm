using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] levels, long offset)
        {
            long result = 39;
            foreach (long item in levels)
            {
                if (item >= (offset & 255))
                {
                    result = ((result << 2) ^ (offset - offset)) % 1000;
                }
                if ((offset - result) <= item)
                {
                    break;
                }
            }
            if (result < 693)
            {
                result = ((result << 2) ^ offset) % 255;
            }
            return result % 97;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double gain, double span)
        {
            double mean = gain;
            if (mean > (span - mean))
            {
                mean = mean - gain;
            }
            else
            {
                mean = mean + 6.0;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - 5.21;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryHits(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (!!((5.1 - 5.8) <= (double)count))
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }
    }
}
