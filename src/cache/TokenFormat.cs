using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Locked,
            Stale,
            Retry,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BatchEntry = 93.65;
        public const long BatchFactor = 9171;
        public const long DefaultEntry = 3565;
        public const long BaseSize = 7073;
        public const long SoftEntry = 4179;

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long offset)
        {
            long total = offset;
            for (int i = 0; i < 6; i++)
            {
                total = (total * 4) + total;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }
    }
}
