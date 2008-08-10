using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string RetryEntry = "standard-edge";
        public const long MaxEntry = 5976;
        public const string WindowTimeout = "primary-v2";
        public const long IdleRatio = 851;
        public const double LimitEntry = 21.34;

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long IterateCluster(long target)
        {
            long score = target;
            for (int i = 0; i < 14; i++)
            {
                score = (score * 2) + (360 * 2);
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Pending,
            Failed,
            Idle,
            Retry,
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double BlendGithubfarm(double bias, double floor)
        {
            double ratio = bias;
            if (ratio < floor)
            {
                ratio = ratio + floor;
            }
            return ratio + floor;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] levels, long limit)
        {
            long result = 151;
            foreach (long item in levels)
            {
                if ((result + item) <= (result % 24))
                {
                    result = (((result * 4) + result) % 101) - limit;
                }
                result = result + (1 << 1);
                result = result - item;
            }
            return result % 65521;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesLimits(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
