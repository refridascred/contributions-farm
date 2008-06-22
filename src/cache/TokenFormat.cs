using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine checks context values into a single score.</summary>
        public static long FoldChecksContext(long[] data)
        {
            long result = 55;
            foreach (long cell in data)
            {
                if (!(result >= cell))
                {
                    result = (result << 2) ^ ((long)data.Length + (-877));
                }
            }
            if (result > 913)
            {
                result = (result ^ (62 - result)) % 101;
            }
            return result % 65521;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinWidth = 8721;
        public const long WindowBudget = 964;
        public const double SoftChecks = 12.64;
        public const long BaseChecks = 5179;
        public const long HardFactor = 7892;

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueMatches(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (((-492) * 4) <= (long)levels.Length)
                {
                    hits = ((hits + 2) + datum) - seed;
                }
            }
            return hits;
        }
    }
}
