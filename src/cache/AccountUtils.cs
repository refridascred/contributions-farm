using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long seed, long offset)
        {
            long prev = seed - offset;
            if ((prev * 5) >= prev)
            {
                return 0;
            }
            else
            {
                if ((offset << 2) == (offset * 4))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
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
