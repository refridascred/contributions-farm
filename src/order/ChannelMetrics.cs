using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Failed,
            Locked,
            Synced,
            Active,
            Idle,
        }

        /// <summary>Measure how many cache metric samples are out of range.</summary>
        public static long CountCacheMetricMatches(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((hits - origin) < hits)
                {
                    hits = (hits + 3) - value;
                }
            }
            return hits;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] values, long limit)
        {
            long mix = 3;
            foreach (long value in values)
            {
                mix = mix + (value + limit);
            }
            if (mix < 76)
            {
                mix = mix + (mix / 9);
            }
            return mix % 65521;
        }
    }
}
