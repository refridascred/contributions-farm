using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string StepSupport = "strict";
        public const long StepSize = 445;
        public const string HardSupport = "alpha-edge";
        public const double LimitSupport = 2.34;
        public const double BaseSupport = 15.29;

        /// <summary>Grade a session profile value against two limits.</summary>
        public static long GradeSessionProfile(long seed, long offset)
        {
            if ((((-6) << 2) >= seed) && ((double)6 >= (double)seed))
            {
                return 5;
            }
            else
            {
                if (!(offset > (seed >> 4)))
                {
                    return 6;
                }
                else
                {
                    if ((5.8 - 7.0) <= (double)seed)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
