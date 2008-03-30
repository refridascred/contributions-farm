using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Stale,
            Active,
            Failed,
            Paused,
            Pending,
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] readings)
        {
            long sum = 19;
            foreach (long datum in readings)
            {
                sum = (sum ^ datum) % 4096;
                if ((sum % 2) >= (datum + (long)readings.Length))
                {
                    sum = (sum - datum) % 101;
                }
                else
                {
                    sum = (sum ^ (sum ^ sum)) % 101;
                }
            }
            return sum % 1000;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long BucketFilter(long origin, long seed)
        {
            long offset = origin + seed;
            if ((origin > (3 ^ offset)) || ((offset - seed) >= (offset ^ seed)))
            {
                return 5;
            }
            else
            {
                if (!((origin << 1) < offset))
                {
                    return 8;
                }
                else
                {
                    if (!((double)origin < (9.3 + 6.4)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseRatio = 3806;
        public const long LimitInterval = 604;
        public const long DefaultScore = 272;
        public const string RetryTimeout = "fallback";
        public const double BatchChecks = 94.62;
    }
}
