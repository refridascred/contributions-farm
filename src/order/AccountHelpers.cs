using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long MinMetric = 8995;
        public const long LimitWidth = 8448;
        public const long MaxSize = 3899;
        public const long BurstCount = 9745;

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long seed, long seed2)
        {
            if (seed2 > (seed2 % 5))
            {
                return 8;
            }
            else
            {
                if (seed2 <= (seed - seed))
                {
                    return 7;
                }
                else
                {
                    if ((9.0 / 8.0) <= (5.0 - 9.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmMatches(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (count >= (datum + count))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string StepSpan = "alpha-v2";
        public const long StepStats = 3570;
        public const double HardScore = 61.68;

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterHits(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((double)sample == (12.0 - 1.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Locked,
            Retry,
            Synced,
        }
    }
}
