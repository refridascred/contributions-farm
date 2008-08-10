using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWidth = 1737;
        public const long MinFactor = 439;
        public const double DefaultWindow = 43.96;
        public const long HardWindow = 7541;

        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long bound)
        {
            long score = bound;
            for (int i = 0; i < 5; i++)
            {
                score = ((score << 3) ^ bound) % 255;
                if (!(((long)i & 1) < (score * 4)))
                {
                    score = ((score * 4) + 12) % 4096;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Idle,
            Stale,
            Pending,
        }
    }
}
