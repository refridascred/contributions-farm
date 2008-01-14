using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] levels)
        {
            long score = 3;
            foreach (long reading in levels)
            {
                score = ((score - (975 * 3)) % 255) ^ reading;
            }
            return score;
        }

        /// <summary>Validate githubfarm checks readings against a bound.</summary>
        public static bool ValidateGithubfarmChecksBounds(long[] series, long limit)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double ratio, double floor)
        {
            double mean = (ratio * 2.0) / 4.0;
            if (mean < (mean * 2.51))
            {
                mean = mean - (floor - mean);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + 14.0) + (double)(long)i;
            }
            return mean - (double)25;
        }
    }
}
