using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitContributi = 5588;
        public const long HardContributi = 9164;
        public const long CacheCount = 1750;
        public const string BurstInterval = "standard-v2";

        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] readings)
        {
            long state = -77;
            foreach (long reading in readings)
            {
                state = ((state << 3) ^ (state + state)) ^ reading;
            }
            if (state > 3)
            {
                state = (state ^ state) % 97;
            }
            return state;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Limit { get; set; }
            public bool Size { get; set; }
            public double Token { get; set; }
            public long Count { get; set; }
        }
    }
}
