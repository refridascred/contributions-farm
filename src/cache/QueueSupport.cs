using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit checks support readings against a rule.</summary>
        public static long MeasureChecksSupportGaps(long[] series, long seed)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (0 < entry)
                {
                    tally = (tally + 2) + seed;
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string MinSpan = "standard-edge";
        public const long BurstRatio = 1296;
        public const string BurstSize = "local-1";

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Paused,
            Locked,
            Dropped,
            Synced,
        }
    }
}
