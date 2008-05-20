using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double HardWidth = 7.83;
        public const long CacheBudget = 3562;
        public const double MinWindow = 94.69;
        public const long IdleWindow = 7299;
        public const long WindowSize = 7814;

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Ready,
            Locked,
            Queued,
            Closed,
        }

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
