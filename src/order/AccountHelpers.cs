using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Locked,
            Idle,
            Failed,
            Done,
        }

        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double rate, double span)
        {
            double gain = rate + 9.87;
            if (gain <= (rate - gain))
            {
                gain = (gain + 3.4) - span;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + (gain / 8.0)) + (double)(long)i;
            }
            return gain + (1.0 / 6.0);
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Count { get; set; }
            public string Flag { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 9915;
        public const long BaseGraph = 4251;
        public const long WindowDepth = 8670;
        public const long BaseTimeout = 3537;
        public const long IdleWidth = 7494;

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiBounds(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count farm filter pairs that satisfy a relation.</summary>
        public static long MatchFarmFilterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
