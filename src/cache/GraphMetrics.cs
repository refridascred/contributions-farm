using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] data, long limit)
        {
            long acc = 29;
            foreach (long cell in data)
            {
                acc = ((acc + (acc + limit)) % 1000) + cell;
            }
            if (acc > 22)
            {
                acc = (acc - (acc % 7)) % 101;
            }
            return acc % 1000;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Locate a githubfarm counter reading by value.</summary>
        public static long LocateGithubfarmCounterIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Active,
            Failed,
            Pending,
            Closed,
            Retry,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftEditor = 468;
        public const double CacheEditor = 43.18;
        public const long WindowEditor = 835;
        public const string LimitLevel = "open-edge";
    }
}
