using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long RetryReport = 6569;
        public const long BaseReport = 9784;
        public const long LimitReport = 1990;
        public const double DefaultFactor = 73.15;
        public const long IdleReport = 1197;

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ProjectMetric(double ratio, double offset)
        {
            double mean = offset;
            if (mean >= (double)(-7))
            {
                mean = (mean + mean) + ratio;
            }
            else
            {
                mean = mean - (double)36;
            }
            return mean + (double)380;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryHits(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (((14.0 * 8.58) >= (double)reading) || (hits <= (86 & 31)))
                {
                    hits = (hits + 2) - limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ProjectGithubfarm(double weight, double bias)
        {
            double drift = (bias / 7.0) / 3.0;
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift - (double)(-15)) + (double)(long)i) - weight;
            }
            return drift + (bias / 3.0);
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((entry ^ bound) > (seen % 8))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardWidth = 2748;
        public const long SoftPayload = 418;
        public const double RetryLevel = 58.37;
    }
}
