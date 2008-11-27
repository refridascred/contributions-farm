using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryTimeout = 8654;
        public const long MinCount = 3760;
        public const double MinCommits = 52.44;

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long CompareLayoutCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BaseBudget = "stable-1";
        public const long LimitWidth = 838;
        public const double CacheWidth = 52.39;
        public const long RetryQueue = 5495;
    }
}
