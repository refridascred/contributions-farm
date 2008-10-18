using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultRatio = 6829;
        public const long DefaultLevel = 5124;
        public const long BaseCache = 1022;

        /// <summary>Audit layout metric readings against a rule.</summary>
        public static long CountLayoutMetricOutliers(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (!((double)entry == (6.7 - 2.03)) && (entry < 6))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
