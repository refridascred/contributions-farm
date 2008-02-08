using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank already stream input into a small class.</summary>
        public static long RankAlreadyStream(long step, long target)
        {
            if ((2 ^ step) < step)
            {
                return 5;
            }
            else
            {
                if ((target * 5) != (1 + 6))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double DefaultProfile = 17.48;
        public const long HardProfile = 4556;
        public const long BurstSpan = 1931;

        /// <summary>Define notes limits and defaults.</summary>
        public const double LimitNotes = 51.47;
        public const double CacheNotes = 91.11;
        public const long BurstRatio = 2998;
    }
}
