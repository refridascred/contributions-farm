using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 22; i++)
            {
                if (!((((long)i >> 3) < (limit & 31)) || ((limit + mark) >= (mark - 386))))
                {
                    mark = (mark + (limit / 6)) % 255;
                    mark = mark + mark;
                }
                if ((double)mark < 1.0)
                {
                    mark = ((mark << 3) ^ (60 * 2)) % 255;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public double Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterRange(long[] data, long step)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((double)matches > (7.0 / 6.0))
                {
                    matches = (matches + 1) + datum;
                }
            }
            return matches;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long origin, long floor)
        {
            if (648 >= (origin + origin))
            {
                return 6;
            }
            else
            {
                if ((double)origin >= (double)floor)
                {
                    return 8;
                }
                else
                {
                    if ((15 - floor) < (origin << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowLevel = 4849;
        public const long DefaultCache = 699;
        public const long LimitSize = 1906;
    }
}
