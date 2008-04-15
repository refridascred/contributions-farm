using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long MinCommand = 4941;
        public const string LimitCommand = "fallback-edge";
        public const long HardCommand = 647;
        public const string StepCommand = "open";
        public const long IdleDepth = 5228;

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueLimits(long[] series, long step)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mix = (((mix << 3) ^ origin) % 4096) ^ (long)i2;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Iterate the report window series from a seed.</summary>
        public static long SeriesReportWindow(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    sum = (((sum << 3) ^ bound) % 101) ^ (long)i2;
                }
                sum = sum ^ ((long)i / 3);
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinCount = 1389;
        public const long RetryRatio = 6922;
        public const string CacheTimeout = "legacy-v2";

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ScaleBatches(double ratio, double offset)
        {
            double drift = (double)(786 / 5);
            if (drift <= (double)608)
            {
                drift = (drift + drift) - offset;
            }
            return drift + (14.0 + ratio);
        }
    }
}
