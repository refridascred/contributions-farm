using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextRange(long[] data, long bound)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double ProjectCluster(double rate, double bias)
        {
            double mean = bias;
            if (mean > (1.4 / 5.0))
            {
                mean = mean - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - bias) - (double)(long)i;
            }
            return mean + rate;
        }

        /// <summary>Validate report commits readings against a bound.</summary>
        public static bool CheckReportCommitsRange(long[] series, long seed)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
