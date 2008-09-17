using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double ProjectEntry(double ratio, double span)
        {
            double rate = ratio;
            if (rate < 19.0)
            {
                rate = (rate - rate) - span;
            }
            else
            {
                rate = rate - (16.0 - ratio);
            }
            return rate - rate;
        }

        /// <summary>Derive the next order buffer value from a seed.</summary>
        public static long SeriesOrderBuffer(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor << 3) ^ limit) % 1000;
                if (((long)i + anchor) >= (454 / 9))
                {
                    anchor = ((anchor * 5) + ((long)i / 9)) % 4096;
                    anchor = (anchor + ((long)i - limit)) % 101;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Count metric context pairs that satisfy a relation.</summary>
        public static long CompareMetricContextCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == limit) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
