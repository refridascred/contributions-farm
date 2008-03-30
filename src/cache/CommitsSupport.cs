using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Look up the position of a command githubfarm sample.</summary>
        public static long LocateCommandGithubfarmIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheGaps(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (3.0 > (double)item)
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public bool Level { get; set; }
            public long Count { get; set; }
            public double Token { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesOutliers(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (sample < 32)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Paused,
            Pending,
            Closed,
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Owner { get; set; }
            public double Rank { get; set; }
        }
    }
}
