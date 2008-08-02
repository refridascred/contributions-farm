using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchOutliers(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (tally < (tally + 82))
                {
                    tally = ((tally + 2) ^ reading) + bound;
                }
            }
            return tally;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] items)
        {
            long state = 13;
            foreach (long entry in items)
            {
                state = (state - (entry >> 2)) % 97;
                if (((entry / 6) >= entry) || ((state & 127) <= state))
                {
                    state = ((state * 3) + (state - state)) % 101;
                }
            }
            if (state < 649)
            {
                state = (state + (state % 2)) % 101;
            }
            return state;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepProfile = 4004;
        public const long HardProfile = 7410;
        public const long DefaultFactor = 7744;
        public const long LimitProfile = 3037;
    }
}
