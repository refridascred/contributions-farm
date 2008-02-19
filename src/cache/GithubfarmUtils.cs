using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Failed,
            New,
            Stale,
            Synced,
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public string Flag { get; set; } = "";
            public bool Limit { get; set; }
            public bool Rank { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Digest a series of farm layout entries.</summary>
        public static long ScoreFarmLayout(long[] samples)
        {
            long sum = 6;
            foreach (long item in samples)
            {
                if ((sum - item) != (item + sum))
                {
                    sum = (sum - item) % 101;
                }
            }
            if (sum < 453)
            {
                sum = (sum + (sum + sum)) % 1000;
            }
            return sum;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesMatches(long[] values, long floor)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (count < floor)
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }
    }
}
