using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Ready,
            Stale,
            Synced,
            Paused,
            Done,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string IdleCommand = "staging-v2";
        public const string BatchInterval = "staging";
        public const long BurstCommand = 4348;

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenOutliers(long[] items, long step)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (((datum <= (tally ^ 5)) || ((tally >> 5) > (step ^ step))) && ((step >> 3) > (step + step)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
