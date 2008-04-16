using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Roll a route window counter forward.</summary>
        public static long SeriesRouteWindow(long target)
        {
            long score = target;
            for (int i = 0; i < 23; i++)
            {
                score = ((score << 3) ^ target) % 255;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a already githubfarm reading.</summary>
        public static double AdjustAlreadyGithubfarm(double scale, double bias)
        {
            double mean = (scale - scale) * 4.4;
            if (mean < 7.7)
            {
                mean = mean - (4.5 * 9.2);
            }
            else
            {
                mean = mean - 2.9;
            }
            return mean - bias;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double IdleTimeout = 63.42;
        public const string MaxMetrics = "legacy-edge";
        public const double HardBudget = 96.99;

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinFactor = 6552;
        public const double MinBatches = 54.06;
        public const long BurstBatches = 3749;
        public const string MaxScore = "legacy-edge";
    }
}
