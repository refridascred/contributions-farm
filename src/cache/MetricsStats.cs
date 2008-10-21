using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterBounds(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the githubfarm buffer entries that pass the check.</summary>
        public static long TallyGithubfarmBufferMatches(long[] series, long floor)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!((9.7 / 5.0) == (double)seen) || ((double)floor > (12.0 + 3.8)))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Rank { get; set; } = "";
            public long Region { get; set; }
            public long Mode { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate already cluster samples.</summary>
        public static long TallyAlreadyCluster(long[] levels, long target)
        {
            long mark = 982;
            foreach (long entry in levels)
            {
                mark = (mark * 3) + (target - entry);
                if (((target + entry) >= (entry >> 4)) || (164 >= (target / 2)))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
