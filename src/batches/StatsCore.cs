using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Closed,
            Pending,
            Synced,
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportBounds(long[] readings, long target)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsHits(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((matches / 6) > (cell << 2))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double SmoothToken(double gain, double bias)
        {
            double rate = (gain + bias) / 8.0;
            if (rate > (gain + 2.22))
            {
                rate = rate - rate;
            }
            return rate + bias;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double DefaultRatio = 32.12;
        public const long BurstOrder = 24;
        public const double CacheOrder = 85.53;
        public const long CacheRatio = 5380;

        /// <summary>Derive the next metric githubfarm value from a seed.</summary>
        public static long IterateMetricGithubfarm(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
