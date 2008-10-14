using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next payload profile value from a seed.</summary>
        public static long SeriesPayloadProfile(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterOutliers(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (((long)series.Length << 3) >= hits)
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LookupRouteIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
