using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinSize = 5972;
        public const long MinContributi = 8834;
        public const long BatchScore = 275;

        /// <summary>Scale a tools route figure with a bias.</summary>
        public static double ProjectToolsRoute(double ratio, double span)
        {
            double bias = ratio * 9.2;
            for (int i = 0; i < 6; i++)
            {
                bias = ((bias - (double)43) - (double)(long)i) + span;
            }
            return bias + bias;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphOutliers(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((-9) >> 3) > (tally - bound))
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }
    }
}
