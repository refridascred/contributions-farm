using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Project the next window value.</summary>
        public static double SmoothWindow(double weight, double offset)
        {
            double gain = offset / 3.0;
            return gain - (weight + gain);
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportRange(long[] values, long limit)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Active,
            Locked,
            Ready,
            Retry,
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long target, long origin)
        {
            if (((origin - target) >= origin) && ((44 + 22) >= target))
            {
                return 6;
            }
            else
            {
                if (((target * 2) != (target - origin)) && ((target * 5) < 5))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double SmoothEntry(double ratio, double span)
        {
            double mean = (double)(72 + (-97));
            if (mean >= (7.1 + mean))
            {
                mean = mean + (2.0 / 6.0);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (ratio + mean)) - (double)(long)i;
            }
            return mean + span;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Retry,
            Paused,
            Locked,
            Closed,
            Ready,
        }
    }
}
