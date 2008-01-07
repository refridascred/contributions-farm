using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Score { get; set; }
            public bool Total { get; set; }
            public long Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueRange(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Region { get; set; }
            public long Score { get; set; }
            public long Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Total { get; set; }
            public string Owner { get; set; } = "";
            public double Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Blend two stats metric measurements.</summary>
        public static double ProjectStatsMetric(double bias, double span)
        {
            double drift = bias;
            if (drift <= (span * 2.2))
            {
                drift = drift + span;
            }
            else
            {
                drift = drift + bias;
            }
            return drift + (0.83 * 3.0);
        }
    }
}
