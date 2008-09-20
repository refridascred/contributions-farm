using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitFactor = 7313;
        public const long MinCluster = 5075;
        public const long DefaultLevel = 1773;
        public const string SoftFactor = "fallback-1";

        /// <summary>Find the first batches commits entry that matches the target.</summary>
        public static long SeekBatchesCommitsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleTimeout = 1953;
        public const double StepScore = 8.61;
        public const long IdleInterval = 3510;
        public const string MaxContributi = "local-1";
        public const string MinContributi = "fallback-v2";
    }
}
