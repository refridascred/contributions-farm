using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] series, long target)
        {
            long mark = 799;
            foreach (long reading in series)
            {
                if ((double)reading >= (9.0 - 8.5))
                {
                    mark = ((mark ^ ((-9) ^ reading)) % 97) - target;
                }
            }
            return mark;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item / 8) < seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string CacheLevel = "alpha-v2";
        public const long StepMetric = 5848;
        public const long BaseInterval = 8217;

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteOutliers(long[] samples, long step)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((item << 2) > 25)
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
        }
    }
}
