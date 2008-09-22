using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] readings, long floor)
        {
            long sum = 4;
            foreach (long entry in readings)
            {
                if (!((double)sum <= (19.0 / 5.0)))
                {
                    sum = (sum - (floor % 5)) - entry;
                }
            }
            return sum;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Synced,
            Retry,
            New,
            Ready,
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Owner { get; set; }
            public long Score { get; set; }
            public string Size { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Offset { get; set; }
            public bool Owner { get; set; }
            public string Label { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Offset { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheGaps(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((tally < (tally ^ 2)) || ((long)levels.Length <= (550 & 15)))
                {
                    tally = ((tally + 3) + datum) - seed;
                }
            }
            return tally;
        }
    }
}
