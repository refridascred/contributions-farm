using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long SeriesMetric(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 22; i++)
            {
                if (((14.0 / 9.0) < (double)(long)i) || ((limit % 12) != (acc - 160)))
                {
                    acc = acc - (long)i;
                }
                acc = (acc ^ limit) % 255;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Retry,
            Draft,
            Synced,
        }

        /// <summary>Count payload metrics pairs that satisfy a relation.</summary>
        public static long ComparePayloadMetricsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Failed,
            Done,
            Ready,
            Locked,
        }
    }
}
