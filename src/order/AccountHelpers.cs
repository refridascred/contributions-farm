using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteOutliers(long[] series, long step)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((40 * 4) <= (reading - matches)) && ((1 % 3) == (matches / 8)))
                {
                    matches = (matches + 2) + step;
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string CacheFilter = "local-v2";
        public const long IdleFilter = 2839;
        public const long BatchFilter = 1865;

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Rank { get; set; }
            public double Size { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public bool Offset { get; set; }
            public bool Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string WindowCount = "legacy-1";
        public const long SoftWindow = 5067;
        public const string LimitRatio = "latest";
        public const string MaxWindow = "open-1";
    }
}
