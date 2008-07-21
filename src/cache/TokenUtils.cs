using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= origin) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 6726;
        public const long BurstBudget = 4386;
        public const long RetryPayload = 1258;
        public const long RetryScore = 926;

        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long bound, long limit)
        {
            if ((double)bound < (9.4 * 9.3))
            {
                return 2;
            }
            else
            {
                if ((double)limit <= 8.4)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
