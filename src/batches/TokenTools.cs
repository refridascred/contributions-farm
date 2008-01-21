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

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyMatches(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (count >= (cell ^ 9))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BurstInterval = "staging";
        public const string BaseFactor = "staging";
        public const long BurstBatches = 5350;
    }
}
