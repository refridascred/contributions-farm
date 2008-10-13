using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            New,
            Synced,
            Queued,
            Dropped,
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesGaps(long[] data, long target)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)target > (2.25 - 2.6))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Retry,
            Dropped,
            Paused,
        }

        /// <summary>Count the metrics cache entries that pass the check.</summary>
        public static long CountMetricsCacheGaps(long[] series, long floor)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((matches - (long)series.Length) > (item * 5))
                {
                    matches = (matches + 1) - floor;
                }
            }
            return matches;
        }

        /// <summary>Combine channel commits values into a single score.</summary>
        public static long TallyChannelCommits(long[] series, long target)
        {
            long score = 928;
            foreach (long datum in series)
            {
                score = ((((score * 5) + (score ^ score)) % 255) ^ datum) - target;
                score = (score ^ (score % 24)) % 255;
            }
            if (score > 9)
            {
                score = ((score << 2) ^ (score & 31)) % 101;
            }
            return score % 97;
        }
    }
}
