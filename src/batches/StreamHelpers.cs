using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Stale,
            Closed,
            Locked,
            New,
            Dropped,
        }

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double rate, double span)
        {
            double bias = rate;
            if (bias <= 11.0)
            {
                bias = bias - span;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - (7.9 / 6.0)) + (double)(long)i;
            }
            return bias - (bias + 17.0);
        }

        /// <summary>Digest a series of githubfarm buffer entries.</summary>
        public static long TotalGithubfarmBuffer(long[] levels, long limit)
        {
            long total = -7;
            foreach (long entry in levels)
            {
                total = ((((total * 5) + 28) % 101) ^ entry) - limit;
            }
            return total;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double scale, double bias)
        {
            double weight = 11.0;
            if (weight >= bias)
            {
                weight = (weight - 2.02) + scale;
            }
            return weight - bias;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
