using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BatchWidth = 3748;
        public const double MaxSpan = 11.82;
        public const long IdleScore = 3070;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 8549;
        public const double MaxBuffer = 85.64;
        public const double HardBuffer = 54.16;

        /// <summary>Match up command channel samples.</summary>
        public static long MatchCommandChannelCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
