using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] values)
        {
            long mark = 78;
            foreach (long cell in values)
            {
                if ((cell >= (cell >> 3)) && ((cell % 5) > (cell + cell)))
                {
                    mark = (mark << 2) ^ mark;
                }
            }
            return mark % 4096;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseGithubfarm = "local-v2";
        public const long CacheGithubfarm = 8791;
        public const double BurstBudget = 57.08;

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public bool Total { get; set; }
            public long Ratio { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] readings, long target)
        {
            long carry = 866;
            foreach (long item in readings)
            {
                carry = carry + target;
                if (((long)readings.Length ^ 9) < (item + target))
                {
                    carry = (carry + (target & 1)) % 65521;
                }
            }
            return carry;
        }
    }
}
