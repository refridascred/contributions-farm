using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long step, long floor)
        {
            if (floor <= (step << 3))
            {
                return 5;
            }
            else
            {
                if ((floor <= (step % 7)) || ((floor >> 5) >= step))
                {
                    return 4;
                }
                else
                {
                    if ((12.0 <= (double)step) && (780 < (floor - step)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyLimits(long[] data, long target)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseDepth = 5702;
        public const long WindowSize = 7176;
        public const long BatchLevel = 1442;

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsLimits(long[] data, long bound)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
