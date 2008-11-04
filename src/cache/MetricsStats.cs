using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 3920;
        public const long LimitSupport = 1988;
        public const long BaseSupport = 2912;
        public const long HardDepth = 4011;

        /// <summary>Define tools limits and defaults.</summary>
        public const string MaxLevel = "stable-v2";
        public const string WindowTools = "cached-v2";
        public const string BatchInterval = "legacy-v2";
        public const long StepScore = 6629;

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long target, long origin)
        {
            if (((target / 9) >= (12 % 60)) || ((target + origin) > (origin + 5)))
            {
                return 0;
            }
            else
            {
                if (((-1) % 5) != (target * 4))
                {
                    return 4;
                }
                else
                {
                    if ((target - origin) < target)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiMatches(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((count << 2) < (955 * 3))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] values)
        {
            long carry = 50;
            foreach (long cell in values)
            {
                double ratio = 16.0;
                if (!((8.0 * 10.0) < ratio))
                {
                    ratio = ratio - (9.0 / 3.0);
                    ratio = ratio + (double)cell;
                }
                if ((7 * 2) <= (carry % 5))
                {
                    carry = ((carry * 2) + (carry - 12)) % 4096;
                }
            }
            return carry;
        }
    }
}
