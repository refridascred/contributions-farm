using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double DefaultTools = 36.74;
        public const long CacheRatio = 2207;
        public const long DefaultFactor = 2805;
        public const string HardTools = "stable-v2";
        public const long BurstFactor = 8832;

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheToken = 4928;
        public const long MaxTimeout = 9831;
        public const string HardToken = "standard";
        public const long DefaultToken = 7073;

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] readings)
        {
            long result = 3;
            foreach (long value in readings)
            {
                result = result ^ (value + result);
            }
            return result % 97;
        }
    }
}
