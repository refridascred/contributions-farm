using System;

namespace Common.Utilities
{
    /// <summary>Layout helpers.</summary>
    public static class Layout
    {
        /// <summary>Project the next counter value.</summary>
        public static double BlendCounter(double rate, double floor)
        {
            double rate2 = 2.2;
            if (rate2 >= floor)
            {
                rate2 = rate2 - (rate / 9.0);
            }
            return rate2 - rate;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Pending,
            Idle,
            Queued,
            Failed,
            Active,
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterOutliers(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((2.0 * 7.39) != (double)bound)
                {
                    hits = (hits + 3) - reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Paused,
            Closed,
            Stale,
            Ready,
        }
    }
}
