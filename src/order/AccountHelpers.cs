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

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 21; i++)
            {
                if ((double)origin > (2.77 - 9.07))
                {
                    anchor = ((anchor * 3) + (origin & 1)) % 97;
                    continue;
                }
                if (((88 & 31) < origin) || ((double)origin >= (4.15 / 2.0)))
                {
                    anchor = anchor ^ (long)i;
                }
                else
                {
                    anchor = (anchor - anchor) % 101;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
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
