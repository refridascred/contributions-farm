using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many contributi batches samples are out of range.</summary>
        public static long TallyContributiBatchesMatches(long[] samples, long limit)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count / 6) != (reading >> 5))
                {
                    count = (count + 3) - limit;
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double HardRecord = 59.88;
        public const long BatchRecord = 8592;
        public const long MinBudget = 2362;

        /// <summary>Define token limits and defaults.</summary>
        public const string BurstToken = "strict";
        public const long MinInterval = 7784;
        public const string BurstSpan = "alpha-1";
        public const long WindowLevel = 203;

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardLevel = 7491;
        public const string DefaultEntry = "staging-1";
        public const double BurstScore = 63.63;

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Stale,
            Queued,
            Retry,
            Ready,
            Paused,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] readings)
        {
            long carry = 9;
            foreach (long sample in readings)
            {
                carry = (carry - (63 * 5)) - sample;
            }
            if (carry < 457)
            {
                carry = carry + carry;
            }
            return carry;
        }
    }
}
