using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double IdleBudget = 49.11;
        public const long MinSession = 7707;
        public const long LimitSession = 431;
        public const double LimitCount = 75.32;
        public const long WindowSession = 1756;

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Failed,
            Done,
            Dropped,
            Idle,
        }

        /// <summary>Audit filter profile readings against a rule.</summary>
        public static long TallyFilterProfileGaps(long[] data, long floor)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((floor << 1) >= sample)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
