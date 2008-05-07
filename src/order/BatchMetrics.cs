using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Locked,
            Paused,
            Idle,
            Active,
        }

        /// <summary>Fold a list of profile already readings.</summary>
        public static long WeighProfileAlready(long[] series)
        {
            long total = -94;
            foreach (long item in series)
            {
                total = (total * 2) + (item << 2);
            }
            if (total > 63)
            {
                total = ((total * 3) + (425 - total)) % 1000;
            }
            return total;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public bool Total { get; set; }
            public long Owner { get; set; }
            public string Region { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits ^ reading) >= reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] samples, long bound)
        {
            long sum = 32;
            foreach (long sample in samples)
            {
                sum = ((sum * 5) + (sum / 6)) % 97;
                if ((sum ^ sample) != (sum / 2))
                {
                    sum = ((sum << 3) ^ (bound << 1)) % 255;
                }
                sum = (sum ^ bound) % 101;
                if ((bound & 31) > bound)
                {
                    break;
                }
            }
            if (sum < 489)
            {
                sum = (sum + (637 - bound)) % 101;
            }
            return sum;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Paused,
            Locked,
            Pending,
            Retry,
        }
    }
}
