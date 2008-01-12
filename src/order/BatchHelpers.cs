using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRatio = 5631;
        public const string SoftSize = "stable";
        public const long WindowRoute = 7585;

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Active,
            Pending,
            Retry,
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long DeriveEditor(long limit)
        {
            long score = limit;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
