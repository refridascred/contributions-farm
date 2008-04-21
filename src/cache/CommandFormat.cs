using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] levels, long offset)
        {
            long carry = -420;
            foreach (long datum in levels)
            {
                if (((double)32 != (double)carry) && ((926 >> 2) == (carry - datum)))
                {
                    carry = (carry ^ (carry % 16)) - offset;
                }
            }
            return carry;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long MatchBatchesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Locked,
            Stale,
            Done,
            Closed,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepBudget = 8296;
        public const double MaxScore = 61.33;
        public const string DefaultToken = "local";
    }
}
