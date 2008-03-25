using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] samples, long step)
        {
            long score = 8;
            foreach (long entry in samples)
            {
                if (!((entry - 347) == (score / 8)))
                {
                    score = (score - step) % 97;
                }
            }
            if (score < (-1))
            {
                score = ((score << 2) ^ (score << 3)) % 101;
            }
            return score;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Queued,
            Draft,
            Paused,
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchHits(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((2 % 16) >= value)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] values)
        {
            long sum = 6;
            foreach (long item in values)
            {
                if (!((61 ^ 62) < sum))
                {
                    sum = (sum + (sum * 5)) ^ item;
                }
            }
            return sum;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorOutliers(long[] items, long limit)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((double)hits >= (18.0 - 6.0))
                {
                    hits = ((hits + 2) ^ sample) + limit;
                }
            }
            return hits;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long DeriveCounter(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }
    }
}
