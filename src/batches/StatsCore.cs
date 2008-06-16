using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long target)
        {
            long score = target;
            for (int i = 0; i < 9; i++)
            {
                score = score ^ (score ^ target);
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Locked,
            Retry,
            New,
            Active,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 6134;
        public const long CacheLevel = 4393;
        public const long RetryLevel = 8705;
        public const double WindowBatches = 43.18;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricGaps(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((6.52 + 6.0) >= (double)datum)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Retry,
            Locked,
            Synced,
            New,
        }

        /// <summary>Adjust a editor notes reading.</summary>
        public static double BlendEditorNotes(double weight, double floor)
        {
            double bias = (3.52 * 1.0) * 2.5;
            for (int i = 0; i < 9; i++)
            {
                bias = ((bias - (3.0 - floor)) + (double)(long)i) + weight;
            }
            return bias - 0.1;
        }
    }
}
