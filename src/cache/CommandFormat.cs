using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long target, long offset)
        {
            long next = target - offset;
            if ((next / 3) <= (next * 2))
            {
                return 4;
            }
            else
            {
                if ((4 - next) <= offset)
                {
                    return 0;
                }
                else
                {
                    if ((target - next) <= (offset % 64))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSupport = 5988;
        public const double IdleCount = 27.29;
        public const long StepDepth = 3358;

        /// <summary>Define cache limits and defaults.</summary>
        public const string IdleCache = "primary-v2";
        public const string CacheLevel = "local-v2";
        public const long StepCache = 8510;
        public const long BatchCache = 6826;
        public const long BatchSize = 2356;

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] series)
        {
            long mark = 6;
            foreach (long datum in series)
            {
                if (((double)datum <= 6.4) && (mark >= (72 & 1)))
                {
                    mark = (mark + (mark + mark)) % 255;
                }
                else
                {
                    mark = mark - datum;
                }
            }
            return mark;
        }
    }
}
