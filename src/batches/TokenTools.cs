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

        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] series, long step)
        {
            long state = 219;
            foreach (long value in series)
            {
                if ((double)(long)series.Length >= 8.9)
                {
                    state = (((state ^ (state & 15)) % 1000) + value) + step;
                }
            }
            return state % 97;
        }
    }
}
