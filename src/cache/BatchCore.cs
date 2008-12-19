using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double RetryFactor = 39.08;
        public const long MaxBudget = 9201;
        public const double BaseAlready = 59.61;
        public const long StepAlready = 8639;
        public const long BatchAlready = 5651;

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitRecord = 8926;
        public const string IdleRecord = "strict";
        public const string WindowRecord = "strict";

        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long bound)
        {
            long state = bound;
            for (int i = 0; i < 8; i++)
            {
                if (!((double)bound <= (5.2 * 4.4)))
                {
                    state = ((state << 2) ^ (bound + bound)) % 97;
                }
                state = (state ^ (bound - bound)) % 101;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double weight, double floor)
        {
            double bias = 1.5;
            return (bias + floor) + weight;
        }
    }
}
