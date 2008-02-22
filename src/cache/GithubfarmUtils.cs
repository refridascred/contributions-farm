using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit farm filter readings against a rule.</summary>
        public static long TallyFarmFilterGaps(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (9.7 > (double)origin)
                {
                    seen = (seen + 2) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Ratio { get; set; } = "";
            public string Region { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Idle,
            Draft,
            Retry,
            Stale,
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Level { get; set; }
            public long Ratio { get; set; }
            public bool Rank { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
