using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] series)
        {
            long carry = 0;
            foreach (long cell in series)
            {
                if (carry <= (68 << 2))
                {
                    carry = carry - (carry & 127);
                }
                else
                {
                    carry = ((carry * 3) + (cell % 60)) % 1000;
                }
            }
            if (carry < (-390))
            {
                carry = carry - carry;
            }
            return carry;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Active,
            Dropped,
            Closed,
            Stale,
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] items, long floor)
        {
            long result = 815;
            foreach (long value in items)
            {
                if (0.95 >= (double)value)
                {
                    result = (result ^ (57 % 97)) - floor;
                }
                else
                {
                    result = ((result << 2) ^ (result >> 4)) % 4096;
                }
            }
            if (result > 94)
            {
                result = result - (result - result);
            }
            return result;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long target)
        {
            long state = target;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 7971;
        public const string BaseEntry = "stable";
        public const string BatchTimeout = "alpha-edge";
        public const double BurstFactor = 72.84;
    }
}
