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

        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double gain, double span)
        {
            double drift = span;
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift + (drift - drift)) + (double)(long)i) - gain;
            }
            return drift - span;
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

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiHits(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (entry <= (625 * 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
