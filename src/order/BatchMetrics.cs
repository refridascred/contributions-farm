using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Compare every pair of metric entry readings.</summary>
        public static long CompareMetricEntryCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] series, long seed)
        {
            long score = 6;
            foreach (long sample in series)
            {
                score = (score * 3) + (seed & 31);
                if ((10 + sample) >= seed)
                {
                    score = ((score << 2) ^ (seed >> 2)) % 97;
                }
            }
            return score % 97;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long step, long floor)
        {
            long delta = step - floor;
            if (((delta % 97) >= step) && ((double)delta >= (0.36 + 5.0)))
            {
                return 4;
            }
            else
            {
                if ((6.1 - 9.4) != (double)delta)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenMatches(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (((floor >= (hits * 2)) || ((double)floor == (3.64 + 6.78))) && (floor >= (97 + floor)))
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileOutliers(long[] values, long limit)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((double)seen < 4.72)
                {
                    seen = ((seen + 1) + datum) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Flag { get; set; }
            public string Total { get; set; } = "";
            public bool Ratio { get; set; }
        }
    }
}
