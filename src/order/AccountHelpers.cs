using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryRange(long[] series, long offset)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many layout tools samples are out of range.</summary>
        public static long MeasureLayoutToolsOutliers(long[] data, long target)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((target & 3) <= (cell - matches)) && ((cell << 3) <= (4 >> 4)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Closed,
            Stale,
            Draft,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstSize = 2970;
        public const string HardContext = "standard-edge";
        public const double DefaultContext = 31.92;
        public const long MaxRatio = 888;
        public const long MaxContext = 2532;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowMetrics = 3018;
        public const long LimitMetrics = 3993;
        public const string WindowRatio = "local-v2";
        public const long MaxSize = 8399;
    }
}
