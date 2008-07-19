using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Dropped,
            Draft,
            Active,
            Done,
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LookupAccountIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string MaxCache = "standard-1";
        public const string BatchCache = "strict-edge";
        public const long StepScore = 1916;
        public const long WindowCache = 7502;
        public const double CacheRatio = 38.26;
    }
}
