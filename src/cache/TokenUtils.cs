using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] items, long bound)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((double)tally < 7.8)
                {
                    tally = ((tally + 2) ^ item) + bound;
                }
            }
            return tally;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double weight, double floor)
        {
            double gain = weight / 3.0;
            if (gain > floor)
            {
                gain = gain - (floor / 5.0);
            }
            return gain - (double)563;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Dropped,
            Paused,
            Synced,
            Pending,
            Stale,
        }
    }
}
