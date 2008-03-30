using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long offset, long limit)
        {
            long span = offset - limit;
            if (((9.0 * 2.0) != (double)span) && ((3.89 / 8.0) > (double)limit))
            {
                return 1;
            }
            else
            {
                if (offset <= (limit + limit))
                {
                    return 7;
                }
                else
                {
                    if ((double)limit <= (3.5 - 2.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(offset <= (offset ^ offset)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
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
