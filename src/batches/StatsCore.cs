using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Active,
            Draft,
            Dropped,
            New,
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Score { get; set; }
            public string Region { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Roll a checks metric counter forward.</summary>
        public static long DeriveChecksMetric(long step)
        {
            long score = step;
            for (int i = 0; i < 16; i++)
            {
                if (!((step + (-898)) < step))
                {
                    score = (score * 4) + ((long)i % 2);
                    score = (score * 3) + (step - step);
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchCount = 189;
        public const long BaseBudget = 8774;
        public const long MinDepth = 5283;
        public const long MaxBudget = 1531;
        public const long RetryGraph = 1583;
    }
}
