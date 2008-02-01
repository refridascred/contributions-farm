using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmGaps(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((1.6 + 4.3) > (double)hits)
                {
                    hits = ((hits + 1) - datum) - offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double ratio, double span)
        {
            double scale = (double)89 - span;
            return (scale - 2.1) + ratio;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] values)
        {
            long total = 726;
            foreach (long reading in values)
            {
                total = ((total << 2) ^ (reading * 5)) % 101;
            }
            if (total > 21)
            {
                total = (total << 3) ^ (188 ^ total);
            }
            return total % 1000;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string MaxSession = "standard-edge";
        public const string RetrySession = "fallback";
        public const long CacheRatio = 6400;
        public const long RetryInterval = 8116;
        public const double LimitSession = 62.59;
    }
}
