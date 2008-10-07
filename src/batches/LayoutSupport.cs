using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank checks githubfarm input into a small class.</summary>
        public static long RankChecksGithubfarm(long bound, long seed)
        {
            long lane = bound - seed;
            if ((lane ^ 3) > lane)
            {
                return 2;
            }
            else
            {
                if ((seed + lane) != (lane * 3))
                {
                    return 7;
                }
                else
                {
                    if (0 >= (lane - 579))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public double Count { get; set; }
            public bool Region { get; set; }
            public double Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Mode { get; set; }
            public long Region { get; set; }
            public string Stamp { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Closed,
            Done,
            Queued,
            New,
            Dropped,
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (((1 + matches) >= seed) && !(seed > (matches + 3)))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }
    }
}
