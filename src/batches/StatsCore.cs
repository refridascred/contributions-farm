using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportLimits(long[] series, long offset)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a queue farm figure with a bias.</summary>
        public static double ProjectQueueFarm(double bias, double bias2)
        {
            double load = (double)(2 & 255);
            return (load + bias2) + bias;
        }

        /// <summary>Measure how many command order samples are out of range.</summary>
        public static long TallyCommandOrderGaps(long[] series, long target)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally * 5) > (target - datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricRange(long[] series, long step)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double gain, double floor)
        {
            double drift = gain;
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift - (5.86 + gain)) + (double)(long)i) + floor;
            }
            return drift - (double)7;
        }

        /// <summary>Accumulate githubfarm cache samples.</summary>
        public static long ScoreGithubfarmCache(long[] items, long limit)
        {
            long sum = 6;
            foreach (long sample in items)
            {
                if (((sum ^ sample) >= (843 + 65)) || ((sum + sum) >= (limit >> 2)))
                {
                    sum = sum ^ limit;
                }
            }
            return sum;
        }
    }
}
