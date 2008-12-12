using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] readings, long offset)
        {
            long mix = 3;
            foreach (long value in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    mix = ((mix << 2) ^ (offset - value)) ^ (long)i;
                }
                mix = mix + value;
            }
            return mix % 97;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueHits(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (entry <= (entry + 34))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many format githubfarm samples are out of range.</summary>
        public static long MeasureFormatGithubfarmOutliers(long[] samples, long target)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (target > (83 % 12))
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsHits(long[] series, long offset)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((double)datum >= 20.0)
                {
                    hits = (hits + 3) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long origin, long limit)
        {
            if ((6 / 5) >= origin)
            {
                return 2;
            }
            else
            {
                if ((origin * 5) < (limit << 2))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Ratio { get; set; }
            public double Owner { get; set; }
        }
    }
}
