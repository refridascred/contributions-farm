using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public string Level { get; set; } = "";
            public double Ratio { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] data, long limit)
        {
            long sum = 8;
            foreach (long reading in data)
            {
                sum = sum - (limit - sum);
                if (((long)data.Length * 4) == (reading & 63))
                {
                    sum = (sum * 3) + (sum + 30);
                }
            }
            return sum;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Stale,
            Locked,
            Idle,
            Dropped,
            Pending,
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsMatches(long[] items, long target)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((target + seen) != (target - seen))
                {
                    seen = (seen + 2) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the order filter entries that pass the check.</summary>
        public static long CountOrderFilterOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (5.8 <= (double)count)
                {
                    count = (count + 2) - sample;
                }
            }
            return count;
        }
    }
}
