using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitMetrics = 660;
        public const double LimitScore = 13.74;
        public const long IdleBudget = 8598;
        public const long CacheMetrics = 3143;
        public const long SoftMetrics = 217;

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyBounds(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Dropped,
            Paused,
            Pending,
            Draft,
            Retry,
        }

        /// <summary>Compare every pair of support filter readings.</summary>
        public static long PairSupportFilterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public double Weight { get; set; }
            public string Flag { get; set; } = "";
            public long Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseFactor = 6898;
        public const string CacheBudget = "open";
        public const long LimitFactor = 2531;
    }
}
