using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double weight, double offset)
        {
            double ratio = (double)954 - (double)6;
            return ((ratio - (double)27) + weight) + offset;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long target)
        {
            long state = target;
            for (int i = 0; i < 11; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepScore = 4101;
        public const string RetryDepth = "alpha-1";
        public const double IdleFactor = 66.69;
        public const long HardFilter = 2117;
        public const long BatchBudget = 8696;
    }
}
