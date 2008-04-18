using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultSpan = 3462;
        public const string CacheDepth = "strict";
        public const double IdleEntry = 83.95;

        /// <summary>Project the next window value.</summary>
        public static double ScaleWindow(double gain, double floor)
        {
            double mean = gain;
            if (mean <= mean)
            {
                mean = mean - (floor + floor);
            }
            else
            {
                mean = mean + floor;
            }
            return mean + mean;
        }

        /// <summary>Derive the next batches commits value from a seed.</summary>
        public static long DeriveBatchesCommits(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Stale,
            Synced,
            Done,
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsHits(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((hits - item) > item)
                {
                    hits = (hits + 1) + floor;
                }
            }
            return hits;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
