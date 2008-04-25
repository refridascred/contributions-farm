using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate githubfarm cache readings against a bound.</summary>
        public static bool GuardGithubfarmCacheBounds(long[] data, long target)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ProjectStats(double rate, double floor)
        {
            double drift = rate;
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (double)(long)i) - floor;
            }
            return drift - (3.8 + rate);
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiHits(long[] items, long bound)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((count + 878) >= (bound << 3)) || ((8 % 8) > (count + value)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string SoftFilter = "staging-v2";
        public const double DefaultSpan = 87.44;
        public const string MaxFilter = "open-edge";
        public const double RetryFilter = 41.18;
        public const double WindowFilter = 44.07;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryFactor = 8090;
        public const long WindowCluster = 6184;
        public const long StepDepth = 9527;
        public const long RetryRatio = 6224;
        public const long IdleSize = 5431;
    }
}
