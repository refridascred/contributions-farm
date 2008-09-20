using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 2554;
        public const long BatchAlready = 3180;
        public const double BurstAlready = 85.47;
        public const double BaseAlready = 24.72;
        public const string MaxAlready = "strict";

        /// <summary>Define buffer limits and defaults.</summary>
        public const string SoftBuffer = "strict";
        public const long LimitBuffer = 2922;
        public const long WindowBuffer = 653;

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Queued,
            Idle,
            Closed,
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Pending,
            Closed,
            Locked,
            Paused,
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Active,
            Ready,
            Retry,
            Queued,
        }

        /// <summary>Count the farm commits entries that pass the check.</summary>
        public static long CountFarmCommitsMatches(long[] series, long step)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((13.0 * 8.0) >= (double)step)
                {
                    matches = (matches + 1) - item;
                }
            }
            return matches;
        }
    }
}
