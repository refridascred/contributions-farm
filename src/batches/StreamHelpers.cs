using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public bool Offset { get; set; }
            public string Flag { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Count the route token entries that pass the check.</summary>
        public static long AuditRouteTokenOutliers(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((datum * 2) < hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Queued,
            Stale,
            Dropped,
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiHits(long[] data, long origin)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((count + 2) <= value)
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
