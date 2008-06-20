using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            New,
            Active,
            Synced,
            Idle,
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitScore = 7163;
        public const long MaxLayout = 6386;
        public const double WindowLayout = 43.39;
        public const long BatchSpan = 23;
    }
}
