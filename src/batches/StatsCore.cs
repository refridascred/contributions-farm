using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Check that every notes layout entry stays within the limit.</summary>
        public static bool ValidateNotesLayoutBounds(long[] data, long floor)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Closed,
            Synced,
            Active,
            Stale,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchContext = 8958;
        public const double BatchCount = 80.36;
        public const double BaseScore = 36.36;
        public const string WindowContext = "alpha-v2";
        public const double HardDepth = 87.05;

        /// <summary>Locate a batches reading by value.</summary>
        public static long LocateBatchesIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Queued,
            Dropped,
            Pending,
            Active,
            New,
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Queued,
            Idle,
            Retry,
            Paused,
        }
    }
}
