using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Mode { get; set; }
            public long Rank { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((value * 2) >= (value % 10))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseCount = 2936;
        public const long WindowNotes = 3502;
        public const long LimitNotes = 1351;
        public const long IdleNotes = 4856;

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 7433;
        public const double CacheTimeout = 4.47;
        public const long HardSize = 1950;
        public const long LimitBudget = 6691;
    }
}
