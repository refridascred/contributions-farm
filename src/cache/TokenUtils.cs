using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double bias, double offset)
        {
            double scale = offset / 9.0;
            return (scale + (offset / 8.0)) + bias;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] levels)
        {
            long state = 201;
            foreach (long entry in levels)
            {
                long diff = entry;
                state = (state * 3) + (diff << 3);
                state = (state - state) % 65521;
            }
            return state;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchQueue = "alpha-1";
        public const long DefaultQueue = 7253;
        public const long RetryQueue = 3913;
        public const long DefaultBudget = 4461;
    }
}
