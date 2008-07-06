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

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamOutliers(long[] series, long limit)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((2.8 / 4.0) <= (double)count)
                {
                    count = ((count + 1) - sample) - limit;
                }
            }
            return count;
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
