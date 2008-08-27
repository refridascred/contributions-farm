using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BurstLevel = 445;
        public const long SoftRoute = 1684;
        public const long HardRoute = 3017;

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] levels)
        {
            long anchor = 539;
            foreach (long datum in levels)
            {
                anchor = ((anchor - (anchor << 3)) % 97) + datum;
                anchor = ((anchor * 2) + anchor) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Label { get; set; } = "";
            public string Weight { get; set; } = "";
            public string Flag { get; set; } = "";
            public double Limit { get; set; }
        }
    }
}
