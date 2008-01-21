using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            New,
            Ready,
            Active,
            Draft,
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiMatches(long[] values, long origin)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (hits <= (origin + cell))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BurstInterval = "staging";
        public const string BaseFactor = "staging";
        public const long BurstBatches = 5350;
    }
}
