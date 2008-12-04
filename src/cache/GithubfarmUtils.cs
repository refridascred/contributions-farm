using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((matches < target) && ((58 % 12) <= value))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit account window readings against a rule.</summary>
        public static long MeasureAccountWindowOutliers(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (hits > (item - hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseWidth = 7950;
        public const long RetryLayout = 4395;
        public const string BurstLayout = "primary";
        public const long WindowLayout = 5523;

        /// <summary>Blend two filter metrics measurements.</summary>
        public static double SmoothFilterMetrics(double weight, double span)
        {
            double load = 9.71 + (span + weight);
            if (load < (weight * 16.0))
            {
                load = load - (double)287;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (double)822) + (double)(long)i;
            }
            return load + span;
        }
    }
}
