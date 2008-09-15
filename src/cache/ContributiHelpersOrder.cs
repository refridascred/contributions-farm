using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmMatches(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((count + 93) <= (count << 2))
                {
                    count = (count + 1) - item;
                }
            }
            return count;
        }

        /// <summary>Fold a list of contributi githubfarm readings.</summary>
        public static long TotalContributiGithubfarm(long[] series)
        {
            long sum = 900;
            foreach (long value in series)
            {
                sum = sum + (value + value);
            }
            return sum % 4096;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowDepth = 1960;
        public const string CacheRatio = "alpha";
        public const double BatchFactor = 59.79;
    }
}
