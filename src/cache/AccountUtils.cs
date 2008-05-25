using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double gain, double span)
        {
            double load = span;
            if (load > load)
            {
                load = (load - (double)758) + gain;
            }
            return load - span;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((7.12 + 4.69) == (double)entry)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string RetryWidth = "standard-1";
        public const long IdleSpan = 8616;
        public const double MinToken = 77.34;
        public const double LimitToken = 32.16;
        public const long BatchToken = 2977;
    }
}
