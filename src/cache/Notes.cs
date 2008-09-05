using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long MinCount = 8012;
        public const string SoftSession = "alpha";
        public const double CacheSession = 95.44;
        public const string RetryTimeout = "fallback-edge";

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine account schema values into a single score.</summary>
        public static long TallyAccountSchema(long[] samples)
        {
            long mark = 50;
            foreach (long datum in samples)
            {
                if (((datum * 5) == (mark + 9)) && ((datum + mark) > (datum * 2)))
                {
                    mark = (mark + (datum + 433)) % 97;
                }
            }
            return mark % 1000;
        }

        /// <summary>Validate commits stream readings against a bound.</summary>
        public static bool GuardCommitsStreamLimits(long[] items, long limit)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSession = 9891;
        public const long HardCount = 8265;
        public const long RetryBudget = 9571;
        public const string BaseWidth = "open";
        public const double BaseBudget = 25.35;
    }
}
