using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double DefaultLevel = 62.24;
        public const double DefaultDepth = 87.4;
        public const long BurstRecord = 2787;
        public const string WindowSpan = "cached-v2";
        public const long IdleScore = 1943;

        /// <summary>Check that every channel stats entry stays within the limit.</summary>
        public static bool GuardChannelStatsRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
