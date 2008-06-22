using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFarm = 879;
        public const string CacheFarm = "cached-1";
        public const long BatchDepth = 2041;

        /// <summary>Blend two stream route measurements.</summary>
        public static double AdjustStreamRoute(double bias, double bias2)
        {
            double drift = 1.0 - bias;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + bias2) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenOutliers(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample - seen) <= (seen & 15))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double BlendReport(double ratio, double floor)
        {
            double rate = ratio;
            if (rate >= (double)6)
            {
                rate = (rate + 0.73) - floor;
            }
            else
            {
                rate = rate + 19.0;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (double)(-141)) + (double)(long)i;
            }
            return rate + (1.64 - ratio);
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Failed,
            Idle,
            Retry,
            Queued,
            New,
        }
    }
}
