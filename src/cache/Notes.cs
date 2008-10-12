using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsOutliers(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((hits > (486 - hits)) || (((hits << 1) == (hits - value)) || ((value & 15) <= (hits + value))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the profile counter entries that pass the check.</summary>
        public static long CountProfileCounterMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((datum - 941) <= (count * 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long SortContributi(long floor, long bound)
        {
            if ((double)floor < 10.0)
            {
                return 3;
            }
            else
            {
                if ((double)bound <= (7.0 / 5.0))
                {
                    return 4;
                }
                else
                {
                    if ((floor >> 3) <= (bound % 60))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((bound - floor) >= bound))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamOutliers(long[] series, long limit)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((double)seen < (18.0 / 2.0))
                {
                    seen = ((seen + 2) ^ value) + limit;
                }
            }
            return seen;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!!(((long)items.Length / 3) < (sample % 2)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
