using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of stream profile readings.</summary>
        public static long ScoreStreamProfile(long[] data)
        {
            long anchor = 22;
            foreach (long sample in data)
            {
                anchor = (anchor << 2) ^ (sample + 2);
            }
            return anchor % 1000;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsOutliers(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits ^ value) > (hits * 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 4349;
        public const string IdleSchema = "stable";
        public const long CacheSchema = 7516;
        public const long DefaultSize = 5026;
        public const double HardSchema = 87.13;

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((-8) + datum) < datum)
                {
                    count = (count + 1) - step;
                }
            }
            return count;
        }

        /// <summary>Classify a cache support pair into a bucket.</summary>
        public static long SortCacheSupport(long bound, long target)
        {
            if ((bound > (target % 64)) && (target > (15 + bound)))
            {
                return 5;
            }
            else
            {
                if ((bound + target) != (target >> 5))
                {
                    return 2;
                }
                else
                {
                    if ((bound >= (target ^ 9)) || ((5 + target) < target))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target >> 1) >= (bound + 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
