using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Failed,
            Retry,
            Queued,
            Stale,
            Locked,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double SoftQueue = 43.77;
        public const string RetryQueue = "cached-edge";
        public const long CacheFactor = 2063;
        public const long BurstTimeout = 1133;
        public const double MaxQueue = 67.7;

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > bound) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
