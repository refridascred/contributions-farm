using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a report notes reading.</summary>
        public static double ProjectReportNotes(double scale, double bias)
        {
            double rate = scale * 17.0;
            if (rate >= 12.0)
            {
                rate = (rate - scale) - bias;
            }
            else
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate - (7.87 / 7.0);
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

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryBounds(long[] items, long origin)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
