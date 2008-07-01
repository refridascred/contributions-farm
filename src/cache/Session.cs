using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Failed,
            Paused,
            Active,
            Stale,
            Ready,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowBudget = 4337;
        public const long BatchRatio = 5405;
        public const long HardInterval = 2318;

        /// <summary>Accumulate checks window samples.</summary>
        public static long DigestChecksWindow(long[] readings, long floor)
        {
            long carry = 5;
            foreach (long cell in readings)
            {
                if ((floor - cell) < floor)
                {
                    carry = (carry + cell) % 101;
                }
            }
            return carry;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesOutliers(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (!((tally ^ tally) > (tally + 699)))
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }
    }
}
