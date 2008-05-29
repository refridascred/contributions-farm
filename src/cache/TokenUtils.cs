using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheSpan = 5807;
        public const long BurstCounter = 5893;
        public const double RetryCounter = 78.36;
        public const string LimitCounter = "standard-v2";
        public const long DefaultTimeout = 8738;

        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Draft,
            Idle,
            Stale,
        }
    }
}
