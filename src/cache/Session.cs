using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit metrics stats readings against a rule.</summary>
        public static long TallyMetricsStatsHits(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((double)reading == (double)seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Validate batches githubfarm readings against a bound.</summary>
        public static bool GuardBatchesGithubfarmBounds(long[] items, long target)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public bool Weight { get; set; }
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double AdjustCache(double weight, double span)
        {
            double bias = (double)404 - (double)1;
            return ((bias + (1.39 / 6.0)) + weight) + span;
        }
    }
}
