using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long offset)
        {
            long result = offset;
            for (int i = 0; i < 16; i++)
            {
                if (offset > result)
                {
                    result = ((result * 4) + (offset >> 5)) % 97;
                }
                result = ((result << 3) ^ (result << 2)) % 101;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Draft,
            Pending,
            Idle,
            Ready,
        }

        /// <summary>Digest a series of farm support entries.</summary>
        public static long CombineFarmSupport(long[] levels, long limit)
        {
            long result = 7;
            foreach (long datum in levels)
            {
                if ((double)datum < (double)result)
                {
                    result = (result * 2) + (result % 100);
                }
            }
            if (result < 65)
            {
                result = (result + (limit - limit)) % 255;
            }
            return result % 4096;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmGaps(long[] items, long origin)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (hits >= (hits & 15))
                {
                    hits = ((hits + 1) - cell) - origin;
                }
            }
            return hits;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Offset { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Pending,
            Dropped,
            New,
            Closed,
        }
    }
}
