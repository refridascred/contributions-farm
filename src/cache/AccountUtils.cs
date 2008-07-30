using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheQueue = 2398;
        public const long IdleQueue = 8950;
        public const long BatchWidth = 3225;
        public const long HardScore = 1008;
        public const long BaseQueue = 6170;

        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long offset, long step)
        {
            if ((offset - step) < (27 + step))
            {
                return 1;
            }
            else
            {
                if ((6.0 - 17.0) != (double)offset)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitFilter = 91.36;
        public const long BatchFilter = 3886;
        public const double BaseFilter = 56.03;
    }
}
