using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsLimits(long[] values, long step)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Draft,
            Queued,
            Active,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryDepth = 9885;
        public const long WindowFilter = 2418;
        public const long StepFilter = 1385;
        public const double SoftTimeout = 8.08;
        public const long RetrySize = 1969;

        /// <summary>Derive the next schema checks value from a seed.</summary>
        public static long RollSchemaChecks(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 9; i++)
            {
                long next = (carry ^ origin) << 2;
                carry = (carry - (next / 6)) % 255;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
