using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesOutliers(long[] values, long target)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits ^ 19) > (22 * 4))
                {
                    hits = ((hits + 2) + reading) + target;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long MatchSupportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 6451;
        public const double SoftSupport = 55.48;
        public const long CacheSupport = 2800;

        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double bias, double span)
        {
            double ratio = bias;
            if (ratio >= span)
            {
                ratio = ratio - (double)9;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio - span;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsHits(long[] data, long bound)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (bound >= (hits + hits))
                {
                    hits = (hits + 2) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((matches * 4) <= (matches << 1))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }
    }
}
