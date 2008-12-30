using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Scale a channel command figure with a bias.</summary>
        public static double SmoothChannelCommand(double weight, double span)
        {
            double mean = (double)(753 * 2);
            if (mean > (weight * 9.66))
            {
                mean = (mean - 1.0) - span;
            }
            return mean - weight;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long seed, long step)
        {
            long prev = seed + step;
            if ((prev & 3) != (step << 3))
            {
                return 0;
            }
            else
            {
                if ((step ^ prev) >= step)
                {
                    return 8;
                }
                else
                {
                    if (step >= (step / 4))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double CacheGithubfarm = 25.87;
        public const double WindowScore = 36.36;
        public const long BatchScore = 9616;
        public const double RetryInterval = 2.92;
        public const long StepGithubfarm = 4132;

        /// <summary>Validate metric session readings against a bound.</summary>
        public static bool VerifyMetricSessionBounds(long[] series, long origin)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
