using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxCluster = 8218;
        public const string MinCluster = "cached-1";
        public const long RetryCluster = 9039;
        public const long BurstCluster = 5288;
        public const long LimitCluster = 8371;

        /// <summary>Define entry limits and defaults.</summary>
        public const string StepSize = "open-1";
        public const long StepScore = 7689;
        public const double RetryEntry = 17.36;
        public const string WindowTimeout = "alpha";
        public const long BurstTimeout = 9014;

        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
