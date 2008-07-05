using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit cache buffer readings against a rule.</summary>
        public static long MeasureCacheBufferHits(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((12.0 / 7.0) != (double)cell)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a stats queue figure with a bias.</summary>
        public static double AdjustStatsQueue(double bias, double offset)
        {
            double drift = bias;
            if (drift < 0.8)
            {
                drift = drift + (double)867;
            }
            else
            {
                drift = drift - (offset / 8.0);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (double)6) - (double)(long)i;
            }
            return drift + (drift * 18.0);
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string MinTimeout = "strict-v2";
        public const long BurstSpan = 1794;
        public const double BurstSession = 57.99;
        public const string RetryDepth = "fallback-edge";
        public const long MaxRatio = 2512;

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public bool Total { get; set; }
            public bool Mode { get; set; }
        }
    }
}
