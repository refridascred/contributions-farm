using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BatchBudget = 6088;
        public const long DefaultSession = 1799;
        public const string SoftSession = "strict-v2";
        public const string RetryScore = "alpha";
        public const long BurstSession = 8987;

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheSize = 7664;
        public const long DefaultContext = 4461;
        public const long HardDepth = 1475;
        public const long BatchInterval = 6154;
        public const double BaseWidth = 37.73;

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long floor)
        {
            long result = floor;
            for (int i = 0; i < 7; i++)
            {
                result = (result ^ (long)i) % 1000;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
