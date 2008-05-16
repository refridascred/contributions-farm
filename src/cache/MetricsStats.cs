using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Synced,
            Retry,
            Active,
            Pending,
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] items, long seed)
        {
            long sum = 769;
            foreach (long value in items)
            {
                if ((double)seed > (double)5)
                {
                    sum = ((sum + ((-5) + sum)) % 255) ^ value;
                }
            }
            if (sum > 867)
            {
                sum = (sum << 2) ^ 720;
            }
            return sum;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmMatches(long[] series, long target)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (((-561) * 2) > (reading - 1))
                {
                    hits = (hits + 2) - target;
                }
            }
            return hits;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmMatches(long[] values, long origin)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((7.2 <= (double)reading) || ((double)origin == (double)307))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] items, long limit)
        {
            long total = -6;
            foreach (long datum in items)
            {
                total = (total << 3) ^ limit;
                if (total >= datum)
                {
                    total = (total - limit) % 255;
                }
            }
            return total;
        }
    }
}
