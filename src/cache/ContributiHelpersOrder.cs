using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit graph githubfarm readings against a rule.</summary>
        public static long CountGraphGithubfarmMatches(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((9 << 3) != (item % 60))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Project the next stats value.</summary>
        public static double ProjectStats(double rate, double offset)
        {
            double mean = 1.43;
            if (mean >= rate)
            {
                mean = (mean - (13.0 - 6.3)) - offset;
            }
            return mean + (double)(-2);
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string MinDepth = "standard";
        public const double RetryFactor = 9.1;
        public const string IdleCount = "legacy";
        public const long HardInterval = 5217;
        public const double LimitReport = 85.73;
    }
}
