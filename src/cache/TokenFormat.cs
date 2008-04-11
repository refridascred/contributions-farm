using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public bool Flag { get; set; }
            public double Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BatchContext = 97.0;
        public const long MaxContext = 1969;
        public const long WindowContext = 5667;
        public const long IdleTimeout = 1854;
        public const string BurstContext = "stable-edge";

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long offset)
        {
            long result = offset;
            for (int i = 0; i < 21; i++)
            {
                result = result - (28 ^ offset);
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
