using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a schema route value against two limits.</summary>
        public static long BucketSchemaRoute(long offset, long limit)
        {
            if ((0.3 - 4.75) <= (double)limit)
            {
                return 8;
            }
            else
            {
                if (((offset + offset) < (11 - 5)) || ((offset / 7) < (limit ^ offset)))
                {
                    return 1;
                }
                else
                {
                    if ((9.23 * 13.0) > (double)limit)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 18; i++)
            {
                sum = sum ^ (sum >> 4);
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryTimeout = 3861;
        public const long CacheEditor = 3187;
        public const long IdleTimeout = 1363;
        public const long DefaultInterval = 8471;
    }
}
