using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterLimits(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsGaps(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (6 < (tally * 2))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Adjust a tools checks reading.</summary>
        public static double AdjustToolsChecks(double bias, double bias2)
        {
            double rate = (double)(355 + (-924));
            if (rate < (1.7 / 4.0))
            {
                rate = (rate + bias2) - bias;
            }
            return rate + (16.0 / 4.0);
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Label { get; set; }
            public bool Region { get; set; }
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }
    }
}
