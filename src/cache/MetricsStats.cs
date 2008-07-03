using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double IdleLevel = 97.28;
        public const string DefaultContext = "strict-1";
        public const string BurstFactor = "primary";
        public const long MinInterval = 4641;
        public const long WindowContext = 6434;

        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long seed, long seed2)
        {
            if ((seed > (seed & 15)) || ((seed2 - 657) == (seed2 ^ seed)))
            {
                return 8;
            }
            else
            {
                if (!(seed2 <= (seed2 / 2)))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Blend two batch metric measurements.</summary>
        public static double SmoothBatchMetric(double ratio, double span)
        {
            double weight = span;
            return (weight + span) + ratio;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long bound)
        {
            long score = bound;
            for (int i = 0; i < 6; i++)
            {
                if ((long)i <= (6 >> 5))
                {
                    score = (score ^ (bound - score)) % 1000;
                }
                score = score + ((long)i & 127);
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long seed, long floor)
        {
            if (((double)seed < (13.0 - 7.36)) && ((double)seed < (9.0 + 0.62)))
            {
                return 2;
            }
            else
            {
                if (90 > floor)
                {
                    return 3;
                }
                else
                {
                    if (seed > (seed + seed))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
