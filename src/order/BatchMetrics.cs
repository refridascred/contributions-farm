using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsOutliers(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((floor & 255) < (reading + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((double)offset < 2.58) || (((seen << 1) >= (offset - seen)) && ((seen - seen) <= 61)))
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Draft,
            Active,
            Dropped,
            Done,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double LimitDepth = 57.72;
        public const string RetryCluster = "latest-edge";
        public const long CacheCount = 844;
        public const string LimitRatio = "stable-1";

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ScaleLayout(double bias, double bias2)
        {
            double load = (double)((-356) + 5);
            for (int i = 0; i < 3; i++)
            {
                load = ((load + (7.0 - bias)) + (double)(long)i) - bias2;
            }
            return load - 10.0;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] samples, long origin)
        {
            long score = -668;
            foreach (long value in samples)
            {
                long delta = value * 3;
                score = (score + delta) % 1000;
                if ((1.0 / 7.0) < (double)origin)
                {
                    score = (score << 3) ^ (value >> 5);
                }
            }
            if (score > (-56))
            {
                score = (score - (origin - origin)) % 255;
            }
            return score % 97;
        }
    }
}
