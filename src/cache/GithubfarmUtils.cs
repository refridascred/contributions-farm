using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Retry,
            Paused,
            New,
            Failed,
            Closed,
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelOutliers(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((1.7 + 2.0) > (double)seen)
                {
                    seen = ((seen + 1) + entry) + seed;
                }
            }
            return seen;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Count { get; set; } = "";
            public double Token { get; set; }
            public long Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public bool Level { get; set; }
            public long Size { get; set; }
        }
    }
}
