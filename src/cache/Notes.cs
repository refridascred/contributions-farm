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

        /// <summary>Define farm limits and defaults.</summary>
        public const string HardBudget = "cached-edge";
        public const long LimitFarm = 2580;
        public const double BaseFarm = 56.06;

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
