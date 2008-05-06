using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Draft,
            Locked,
            Done,
            Stale,
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiGaps(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell <= (matches ^ 52)) || (((double)cell != (8.59 * 9.0)) || (matches <= (cell + cell))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
            public long Limit { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public bool Count { get; set; }
            public bool Owner { get; set; }
            public double Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Offset { get; set; }
            public bool Level { get; set; }
            public string Rank { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] values)
        {
            long sum = 612;
            foreach (long sample in values)
            {
                if ((994 + sum) < sum)
                {
                    sum = ((sum * 5) + sample) % 65521;
                }
            }
            return sum;
        }
    }
}
