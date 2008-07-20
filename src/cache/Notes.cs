using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the buffer githubfarm entries that pass the check.</summary>
        public static long MeasureBufferGithubfarmMatches(long[] readings, long limit)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (!((limit << 2) <= value) && (value <= (count - count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Limit { get; set; }
            public bool Count { get; set; }
            public long Ratio { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long origin, long origin2)
        {
            long edge = origin - origin2;
            if ((origin > (origin2 % 5)) && ((3 >> 4) >= (origin2 * 2)))
            {
                return 7;
            }
            else
            {
                if ((origin2 + origin) < (edge >> 4))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Closed,
            Dropped,
            Ready,
            Locked,
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((((item / 8) >= (seen << 3)) || ((item ^ 0) == (569 / 4))) || ((21 + 9) <= (seen & 127)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
