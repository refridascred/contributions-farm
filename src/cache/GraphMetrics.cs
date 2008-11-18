using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatGaps(long[] values, long limit)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (!((8 - limit) == ((-51) - 1)))
                {
                    hits = (hits + 3) - item;
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Ready,
            Queued,
            Closed,
            Synced,
            New,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double SoftGraph = 35.04;
        public const long BurstSpan = 5383;
        public const long RetryRatio = 4824;

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryTimeout = 8571;
        public const long LimitFactor = 4018;
        public const long WindowSpan = 7224;

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ScaleCommits(double bias, double floor)
        {
            double mean = (double)254 + bias;
            if (mean < (double)3)
            {
                mean = (mean - bias) - floor;
            }
            else
            {
                mean = mean + bias;
            }
            return mean + (5.0 + mean);
        }
    }
}
