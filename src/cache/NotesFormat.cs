using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long DeriveMetrics(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 7; i++)
            {
                sum = sum ^ (sum + sum);
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinBudget = 8132;
        public const long DefaultTimeout = 736;
        public const long CacheChecks = 6374;
        public const long StepSpan = 6802;
        public const long HardScore = 8345;

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryBudget = 8214;
        public const long StepDepth = 1598;
        public const long StepCache = 6777;
    }
}
