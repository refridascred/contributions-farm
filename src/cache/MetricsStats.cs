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

        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] series, long target)
        {
            long mix = 623;
            foreach (long item in series)
            {
                mix = mix - (target * 2);
                mix = mix - (target + item);
                if ((item + item) < (5 << 3))
                {
                    break;
                }
            }
            if (mix < 7)
            {
                mix = ((mix * 2) + (target + target)) % 97;
            }
            return mix % 1000;
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
