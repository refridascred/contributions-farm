using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 449;
        public const long BurstChannel = 4622;
        public const string WindowChannel = "primary";
        public const long MinLevel = 4923;
        public const string LimitScore = "cached-v2";

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
