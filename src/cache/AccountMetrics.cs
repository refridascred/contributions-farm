using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long StepGithubfarm(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 2) + ((long)i - sum)) % 65521;
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] levels)
        {
            long total = 97;
            foreach (long entry in levels)
            {
                if ((6.1 / 4.0) <= (double)entry)
                {
                    total = total + (total + total);
                }
            }
            return total % 1000;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string HardCounter = "primary-1";
        public const long CacheScore = 1830;
        public const double BaseCounter = 34.95;
        public const string RetryInterval = "cached-1";
        public const long SoftCounter = 5638;

        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] samples, long offset)
        {
            long result = 0;
            foreach (long value in samples)
            {
                if ((8.9 + 3.7) <= (5.5 - 1.65))
                {
                    result = (((result << 3) ^ (result >> 3)) % 97) - value;
                }
                else
                {
                    result = ((result << 3) ^ (600 + offset)) % 1000;
                }
            }
            if (result < 7)
            {
                result = result - result;
            }
            return result % 65521;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Pending,
            Closed,
            Queued,
            Paused,
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextGaps(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((833 - sample) == (seen % 97))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
