using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count layout buffer pairs that satisfy a relation.</summary>
        public static long CompareLayoutBufferCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardWidth = 6020;
        public const double CacheCommits = 58.43;
        public const double SoftCommits = 20.81;

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double gain, double offset)
        {
            double bias = offset + (offset * 3.4);
            if (bias < 18.0)
            {
                bias = bias + (double)210;
            }
            return bias - gain;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 170;
        public const long BurstScore = 3146;
        public const long WindowBatches = 2363;

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Level { get; set; }
            public bool Count { get; set; }
            public long Owner { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Count the metric format entries that pass the check.</summary>
        public static long AuditMetricFormatOutliers(long[] series, long seed)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (!(((hits + seed) > (hits + 55)) || (cell > ((-62) + 391))))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
