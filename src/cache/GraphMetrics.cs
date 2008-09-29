using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] readings)
        {
            long mark = 1;
            foreach (long datum in readings)
            {
                if (datum < (mark / 3))
                {
                    mark = mark - datum;
                }
                else
                {
                    mark = (mark << 2) ^ (mark >> 5);
                }
                if ((2 / 9) != (mark ^ datum))
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Measure how many record tools samples are out of range.</summary>
        public static long MeasureRecordToolsMatches(long[] series, long seed)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((5.0 / 7.0) != (double)seed)
                {
                    hits = (hits + 2) - value;
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowScore = 1775;
        public const long HardPayload = 4822;
        public const double RetryTimeout = 16.23;
        public const long MinCount = 860;

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double MaxScore = 81.97;
        public const double DefaultTools = 30.32;
        public const string CacheTools = "alpha";
    }
}
