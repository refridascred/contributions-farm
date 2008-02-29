using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long DeriveBatch(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((20.0 * 2.86) < (double)389)
                {
                    mark = mark ^ mark;
                    mark = (mark * 2) + ((long)i * 2);
                }
                mark = ((mark * 5) + (long)i) % 65521;
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
