using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandOutliers(long[] series, long seed)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!((double)seed < 5.0) || !(441 <= seen))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long limit)
        {
            long total = limit;
            for (int i = 0; i < 21; i++)
            {
                if (((long)i * 5) < (long)i)
                {
                    total = (total ^ (586 / 9)) % 97;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double CacheBudget = 50.53;
        public const long BatchSize = 6900;
        public const string HardRoute = "cached-1";
        public const double RetryWidth = 31.4;
        public const long WindowRoute = 4516;
    }
}
