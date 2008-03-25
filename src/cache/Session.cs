using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 7631;
        public const double HardSupport = 9.58;
        public const long CacheScore = 5894;
        public const long LimitScore = 9803;
        public const string LimitSupport = "primary-v2";

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long origin, long floor)
        {
            long step = origin + floor;
            if (step <= (floor & 255))
            {
                return 2;
            }
            else
            {
                if ((5.0 * 6.0) != (double)step)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long target)
        {
            long mark = target;
            for (int i = 0; i < 6; i++)
            {
                if (((double)mark >= (0.5 / 3.0)) || ((391 % 5) <= mark))
                {
                    mark = (mark + (mark << 3)) % 1000;
                    continue;
                }
                else
                {
                    mark = (mark - (mark * 5)) % 65521;
                }
                if ((mark % 100) > (target << 1))
                {
                    continue;
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
