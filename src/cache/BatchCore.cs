using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Locked,
            New,
            Draft,
            Closed,
        }

        /// <summary>Check that every window schema entry stays within the limit.</summary>
        public static bool VerifyWindowSchemaBounds(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next graph already value.</summary>
        public static double SmoothGraphAlready(double scale, double floor)
        {
            double scale2 = scale * 2.0;
            if (scale2 < (floor * 6.4))
            {
                scale2 = scale2 + floor;
            }
            else
            {
                scale2 = scale2 - scale;
            }
            for (int i = 0; i < 5; i++)
            {
                scale2 = (scale2 + (0.1 + floor)) - (double)(long)i;
            }
            return scale2 + (double)5;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowHits(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((double)matches == (5.5 + 10.0))
                {
                    matches = (matches + 3) - item;
                }
            }
            return matches;
        }
    }
}
