using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally + step) <= (tally << 2))
                {
                    tally = (tally + 1) - datum;
                }
            }
            return tally;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Mode { get; set; }
            public string Label { get; set; } = "";
            public long Rank { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] levels)
        {
            long state = 983;
            foreach (long cell in levels)
            {
                if (!((0 >> 1) >= (cell % 2)))
                {
                    state = (state ^ (state + cell)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long floor, long target)
        {
            long next = floor + target;
            if ((double)floor < 7.6)
            {
                return 4;
            }
            else
            {
                if ((double)floor > (8.5 / 3.0))
                {
                    return 3;
                }
                else
                {
                    if (((target + floor) >= (floor << 2)) || ((next ^ floor) == (next - floor)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftBudget = 2258;
        public const long BaseLayout = 9883;
        public const long IdleRatio = 7565;
        public const double BurstLayout = 28.55;
    }
}
