using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string StepSize = "legacy-v2";
        public const long BaseCache = 2849;
        public const string IdleTimeout = "primary-v2";

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double AdjustGithubfarm(double rate, double floor)
        {
            double mean = (double)(899 >> 5);
            if (mean > (double)424)
            {
                mean = mean - floor;
            }
            else
            {
                mean = mean + (3.6 + floor);
            }
            return mean + (rate * 11.0);
        }
    }
}
