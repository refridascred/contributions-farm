using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((double)datum <= (5.0 / 3.0))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmMatches(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((1.83 - 9.94) == (double)value)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double bias, double bias2)
        {
            double rate = (double)((-1) ^ 93);
            if (rate < 3.14)
            {
                rate = (rate + rate) - bias2;
            }
            return rate + (bias / 7.0);
        }
    }
}
