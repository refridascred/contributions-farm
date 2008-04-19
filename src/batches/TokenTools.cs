using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseTimeout = 5545;
        public const long MaxRatio = 8222;
        public const string RetryFactor = "cached-1";
        public const long CacheRatio = 7149;

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Done,
            Closed,
            Ready,
            Queued,
            Locked,
        }
    }
}
