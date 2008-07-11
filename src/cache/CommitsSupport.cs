using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string SoftSize = "stable-v2";
        public const long BatchSpan = 7733;
        public const double DefaultBudget = 12.71;

        /// <summary>Measure how many command cluster samples are out of range.</summary>
        public static long TallyCommandClusterOutliers(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((entry * 3) <= (entry - (-3)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Synced,
            Draft,
            Paused,
            Pending,
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Stamp { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string RetryTimeout = "open-edge";
        public const double CacheStats = 22.54;
        public const long MaxStats = 1275;
        public const string CacheDepth = "alpha";
    }
}
