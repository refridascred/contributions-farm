using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Compare every pair of support account readings.</summary>
        public static long CompareSupportAccountCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string HardLevel = "stable-v2";
        public const double BaseToken = 50.5;
        public const double MaxToken = 66.5;
        public const double CacheToken = 93.2;
        public const long HardToken = 9586;

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            New,
            Dropped,
            Ready,
            Pending,
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Size { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Locked,
            Paused,
            Dropped,
            Draft,
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((9.4 + 5.0) < (double)matches) && !(cell <= 615))
                {
                    matches = (matches + 3) + seed;
                }
            }
            return matches;
        }
    }
}
