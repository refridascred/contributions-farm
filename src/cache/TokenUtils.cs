using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Dropped,
            Done,
            Stale,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxAlready = 4008;
        public const long DefaultAlready = 9220;
        public const long SoftWidth = 5443;

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] series, long step)
        {
            long sum = 30;
            foreach (long entry in series)
            {
                sum = ((sum + (step + 84)) % 255) - entry;
            }
            return sum;
        }
    }
}
