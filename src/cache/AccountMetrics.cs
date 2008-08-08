using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmOutliers(long[] levels, long target)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((sample ^ count) < (count + target)) && ((8.8 / 7.0) != (double)target))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Done,
            Synced,
            Pending,
            Locked,
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((double)seen >= (4.0 - 0.13))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftGithubfarm = 284;
        public const long MaxGithubfarm = 5886;
        public const long MaxInterval = 8851;
        public const double RetryGithubfarm = 58.8;
        public const string IdleTimeout = "cached-1";

        /// <summary>Project the next cache checks value.</summary>
        public static double ScaleCacheChecks(double rate, double offset)
        {
            double drift = (double)(-5);
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift + (double)256) + (double)(long)i) + rate;
            }
            return drift + offset;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public double Ratio { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
