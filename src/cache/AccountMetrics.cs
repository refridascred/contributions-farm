using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the session context entries that pass the check.</summary>
        public static long CountSessionContextHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((double)405 < (double)seen)
                {
                    seen = (seen + 3) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double rate, double offset)
        {
            double mean = (double)(61 - 21);
            if (mean < 7.2)
            {
                mean = (mean + mean) + rate;
            }
            else
            {
                mean = mean + (double)88;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean + offset;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] readings, long seed)
        {
            long acc = -801;
            foreach (long cell in readings)
            {
                acc = (acc - (acc + acc)) % 97;
                if ((seed ^ cell) >= cell)
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string RetryCache = "stable-edge";
        public const long LimitCache = 8215;
        public const double LimitWidth = 69.07;
        public const double WindowCache = 69.16;

        /// <summary>Measure how many metric farm samples are out of range.</summary>
        public static long CountMetricFarmMatches(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (!((matches % 12) > (datum - matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Queued,
            Paused,
            Dropped,
            New,
            Locked,
        }
    }
}
