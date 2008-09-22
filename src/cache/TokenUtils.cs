using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Locked,
            Paused,
            Retry,
            Stale,
            Failed,
        }

        /// <summary>Compare every pair of route notes readings.</summary>
        public static long OverlapRouteNotesCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double LimitDepth = 52.93;
        public const string DefaultFactor = "cached-v2";
        public const long RetrySchema = 4540;
    }
}
