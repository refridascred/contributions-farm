using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string BurstCount = "legacy-edge";
        public const long SoftSession = 9190;
        public const long BurstFactor = 5616;
        public const string CacheSpan = "alpha-1";

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long RollNotes(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double MinEditor = 32.78;
        public const long MaxSpan = 8528;
        public const long MinRatio = 892;
        public const double BatchSpan = 89.84;
        public const long DefaultEditor = 2793;
    }
}
