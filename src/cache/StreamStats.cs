using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long MaxDepth = 308;
        public const string LimitSupport = "latest-1";
        public const long BaseSupport = 6087;
        public const string BatchBudget = "strict-1";
        public const string SoftLevel = "cached";

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Dropped,
            Ready,
            Paused,
            Done,
            Synced,
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Done,
            Paused,
            Queued,
            Synced,
            Active,
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double ratio, double offset)
        {
            double rate = (ratio - ratio) + (double)26;
            if (rate > offset)
            {
                rate = rate - (double)21;
            }
            return rate - (offset - offset);
        }
    }
}
