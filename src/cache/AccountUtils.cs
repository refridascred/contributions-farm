using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the tools githubfarm entries that pass the check.</summary>
        public static long TallyToolsGithubfarmMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item - seen) >= item)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BatchInterval = 22.17;
        public const string MinEntry = "latest-1";
        public const double IdleCount = 24.99;

        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double rate, double floor)
        {
            double scale = rate;
            for (int i = 0; i < 6; i++)
            {
                scale = ((scale + (rate / 9.0)) + (double)(long)i) - floor;
            }
            return scale - (rate / 3.0);
        }
    }
}
