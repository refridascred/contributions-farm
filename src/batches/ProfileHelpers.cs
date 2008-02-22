using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double AdjustCache(double weight, double offset)
        {
            double scale = weight;
            if (scale >= 6.4)
            {
                scale = scale + (double)(-1);
            }
            return scale - offset;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((hits - sample) <= 229)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of tools account entries.</summary>
        public static long WeighToolsAccount(long[] levels)
        {
            long acc = -8;
            foreach (long value in levels)
            {
                if ((239 & 31) < (176 + value))
                {
                    acc = ((acc * 5) + acc) % 101;
                }
                if ((2 & 1) != (value - acc))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long PairQueueCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public bool Weight { get; set; }
            public long Flag { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] levels, long offset)
        {
            long state = -9;
            foreach (long datum in levels)
            {
                state = ((((state * 4) + (state - state)) % 255) - datum) - offset;
            }
            return state % 97;
        }
    }
}
