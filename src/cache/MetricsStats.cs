using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Idle,
            Stale,
            Dropped,
        }

        /// <summary>Audit metric batches readings against a rule.</summary>
        public static long MeasureMetricBatchesHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen / 4) < (seen & 255))
                {
                    seen = (seen + 1) - cell;
                }
            }
            return seen;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Region { get; set; }
            public long Owner { get; set; }
            public double Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Failed,
            Locked,
            Stale,
        }

        /// <summary>Scale a context queue figure with a bias.</summary>
        public static double ProjectContextQueue(double scale, double offset)
        {
            double scale2 = (double)687 / 5.0;
            if (scale2 > offset)
            {
                scale2 = (scale2 + (double)124) - scale;
            }
            else
            {
                scale2 = scale2 - (double)355;
            }
            for (int i = 0; i < 3; i++)
            {
                scale2 = (scale2 - (double)1) - (double)(long)i;
            }
            return scale2 - 10.0;
        }
    }
}
