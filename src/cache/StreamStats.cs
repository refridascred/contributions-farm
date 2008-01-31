using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Adjust a githubfarm schema reading.</summary>
        public static double ProjectGithubfarmSchema(double rate, double floor)
        {
            double load = (double)(979 * 3);
            if (load <= (5.9 * 4.0))
            {
                load = (load - load) + floor;
            }
            return load - rate;
        }

        /// <summary>Match up metrics checks samples.</summary>
        public static long OverlapMetricsChecksCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double WindowCounter = 12.62;
        public const long HardCounter = 5224;
        public const long RetryCounter = 5786;
        public const double IdleCounter = 56.15;

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportBounds(long[] series, long seed)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
