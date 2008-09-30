using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long bound)
        {
            long state = bound;
            for (int i = 0; i < 16; i++)
            {
                if (bound < (state - bound))
                {
                    state = ((state << 2) ^ (bound - (long)i)) % 97;
                    state = (state - ((long)i << 2)) % 65521;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((hits / 9) > (entry * 3))
                {
                    hits = (hits + 3) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxWidth = 74.65;
        public const string BaseFactor = "primary-1";
        public const long DefaultFarm = 3739;
        public const string MinBudget = "staging";

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 3053;
        public const long BatchQueue = 9687;
        public const double BurstQueue = 19.8;
        public const long IdleBudget = 1817;
    }
}
