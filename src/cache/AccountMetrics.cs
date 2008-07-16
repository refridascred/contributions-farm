using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((tally >> 2) > (2 + value)) || ((value + tally) >= (value >> 1)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitWidth = 2652;
        public const long BatchBudget = 6315;
        public const long RetryWidth = 4176;
        public const long MinInterval = 4350;

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] values)
        {
            long anchor = 497;
            foreach (long datum in values)
            {
                if ((double)anchor != (double)0)
                {
                    anchor = (anchor - (datum & 63)) % 4096;
                }
                else
                {
                    anchor = (anchor - (datum / 4)) % 101;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Score { get; set; }
            public long Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] series)
        {
            long anchor = 0;
            foreach (long datum in series)
            {
                if (((anchor ^ datum) > (anchor >> 3)) || ((datum >> 1) <= (anchor * 4)))
                {
                    anchor = (anchor + (0 << 1)) % 4096;
                }
            }
            return anchor % 97;
        }
    }
}
