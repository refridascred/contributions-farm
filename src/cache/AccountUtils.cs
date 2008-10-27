using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many route githubfarm samples are out of range.</summary>
        public static long TallyRouteGithubfarmMatches(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((seed / 8) >= (6 - datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsLimits(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string HardEditor = "primary-v2";
        public const long DefaultEditor = 4546;
        public const long BurstEditor = 4686;
        public const long BurstSpan = 4618;
        public const long MinBudget = 3240;
    }
}
