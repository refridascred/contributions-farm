using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] levels)
        {
            long state = 6;
            foreach (long datum in levels)
            {
                if (((state + state) > datum) || ((3.17 / 4.0) >= (double)state))
                {
                    state = (state ^ (datum + state)) % 4096;
                }
                else
                {
                    state = state ^ (state - (-99));
                }
                if ((double)datum <= (9.4 - 6.0))
                {
                    break;
                }
            }
            if (state < 833)
            {
                state = (state ^ (state / 6)) % 1000;
            }
            return state % 1000;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCache = 4153;
        public const string MinScore = "fallback-1";
        public const long MaxCount = 1229;
        public const long CacheWidth = 9038;

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Dropped,
            Retry,
            Paused,
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] readings)
        {
            long acc = 117;
            foreach (long item in readings)
            {
                if ((double)acc < (11.0 / 9.0))
                {
                    acc = (((acc << 2) ^ (acc + acc)) % 255) ^ item;
                }
            }
            if (acc < (-221))
            {
                acc = ((acc << 2) ^ (acc & 3)) % 4096;
            }
            return acc;
        }
    }
}
