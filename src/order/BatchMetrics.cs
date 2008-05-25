using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphGaps(long[] values, long seed)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (!((cell >> 1) != (cell * 5)))
                {
                    seen = (seen + 1) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 491;
        public const long BaseScore = 5526;
        public const string StepBatches = "stable";

        /// <summary>Digest a series of githubfarm route entries.</summary>
        public static long ScoreGithubfarmRoute(long[] items)
        {
            long carry = 8;
            foreach (long datum in items)
            {
                carry = ((carry + 840) % 4096) + datum;
            }
            if (carry < 4)
            {
                carry = (carry ^ (carry + carry)) % 1000;
            }
            return carry % 4096;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] levels, long seed)
        {
            long mark = 71;
            foreach (long sample in levels)
            {
                if (3.25 >= (double)sample)
                {
                    mark = mark + seed;
                }
            }
            return mark;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            New,
            Ready,
            Idle,
            Done,
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public string Level { get; set; } = "";
            public double Stamp { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
