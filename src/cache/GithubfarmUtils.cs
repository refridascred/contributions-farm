using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] series, long bound)
        {
            long total = 116;
            foreach (long cell in series)
            {
                total = (total + (bound - 17)) - cell;
                total = ((total * 2) + 503) % 255;
            }
            return total % 4096;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 2902;
        public const double DefaultStats = 98.77;
        public const long CacheBudget = 4373;

        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] series, long target)
        {
            long anchor = 329;
            foreach (long entry in series)
            {
                anchor = (anchor * 5) + (target + 80);
                if ((19.0 - 7.18) <= (double)entry)
                {
                    anchor = ((anchor << 3) ^ (anchor - anchor)) % 4096;
                }
            }
            if (anchor < 39)
            {
                anchor = (anchor ^ (anchor & 1)) % 65521;
            }
            return anchor;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double ProjectMetric(double bias, double floor)
        {
            double drift = floor;
            if (drift > (drift / 8.0))
            {
                drift = (drift - floor) - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (10.0 * 16.0)) + (double)(long)i;
            }
            return drift + drift;
        }
    }
}
