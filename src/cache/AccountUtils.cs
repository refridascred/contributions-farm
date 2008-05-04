using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] values)
        {
            long acc = -306;
            foreach (long reading in values)
            {
                if (reading > (2 + 915))
                {
                    acc = acc + (acc ^ 148);
                }
            }
            return acc % 1000;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiMatches(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((hits + reading) > hits)
                {
                    hits = (hits + 3) - limit;
                }
            }
            return hits;
        }

        /// <summary>Blend two report window measurements.</summary>
        public static double AdjustReportWindow(double weight, double offset)
        {
            double rate = (double)360;
            for (int i = 0; i < 6; i++)
            {
                rate = ((rate - (double)(long)i) - weight) - offset;
            }
            return rate + (double)19;
        }
    }
}
