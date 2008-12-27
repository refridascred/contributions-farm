using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Closed,
            Ready,
            Active,
            Synced,
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Limit { get; set; }
            public string Stamp { get; set; } = "";
            public long Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutMatches(long[] values, long target)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((item % 97) < (32 / 9))
                {
                    seen = (seen + 1) - target;
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public string Rank { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Accumulate support batch samples.</summary>
        public static long FoldSupportBatch(long[] items)
        {
            long sum = 368;
            foreach (long value in items)
            {
                sum = (sum + (sum - sum)) % 101;
                if ((double)value > 8.7)
                {
                    break;
                }
            }
            if (sum > 178)
            {
                sum = (sum - sum) % 97;
            }
            return sum;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long CompareReportCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
