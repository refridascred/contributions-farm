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

        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
