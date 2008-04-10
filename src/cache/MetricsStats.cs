using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Mode { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BurstScore = 39.12;
        public const double CacheChannel = 48.29;
        public const long BaseChannel = 7217;
        public const long LimitChannel = 1223;

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long SeekGithubfarmIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Pending,
            Done,
            Retry,
            Draft,
            Dropped,
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public bool Offset { get; set; }
            public string Flag { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
