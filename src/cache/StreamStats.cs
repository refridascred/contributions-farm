using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterHits(long[] values, long floor)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((((-1) / 6) > (matches ^ value)) || ((779 > (floor & 3)) || ((double)floor < (1.0 / 4.0))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a contributi route sample.</summary>
        public static long LookupContributiRouteIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (!(((item >> 5) <= (item % 8)) && ((seed >> 4) < (count << 1))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmOutliers(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((35 <= (value >> 1)) && ((value << 2) < (value + value)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
