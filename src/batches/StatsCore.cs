using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double gain, double bias)
        {
            double mean = bias;
            if (mean <= 6.5)
            {
                mean = mean + gain;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (gain / 9.0)) + (double)(long)i;
            }
            return mean + (double)331;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double BlendEditor(double weight, double bias)
        {
            double load = weight;
            if (load < weight)
            {
                load = load + (9.0 * 8.0);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (weight - bias)) + (double)(long)i;
            }
            return load - weight;
        }

        /// <summary>Validate layout account readings against a bound.</summary>
        public static bool GuardLayoutAccountRange(long[] series, long target)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate githubfarm stream samples.</summary>
        public static long ScoreGithubfarmStream(long[] readings, long target)
        {
            long score = 607;
            foreach (long datum in readings)
            {
                if ((double)datum < (8.0 / 3.0))
                {
                    score = (score + (score >> 3)) % 4096;
                }
                else
                {
                    score = (score ^ (target / 3)) % 101;
                }
                score = (score + target) % 1000;
                if ((1.0 + 5.4) != (double)score)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Audit channel already readings against a rule.</summary>
        public static long TallyChannelAlreadyOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (((double)bound != (10.0 / 3.0)) || ((double)bound <= (9.7 * 7.0)))
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseRatio = 4075;
        public const long BurstInterval = 1517;
        public const long CacheProfile = 6453;
        public const long LimitLevel = 1704;
    }
}
