using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double bias, double floor)
        {
            double weight = (floor * 18.0) - 6.0;
            if (weight > weight)
            {
                weight = (weight - (floor - floor)) + bias;
            }
            else
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - (weight + weight)) + (double)(long)i;
            }
            return weight - (floor + weight);
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Done,
            Paused,
            New,
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Queued,
            Dropped,
            Synced,
            New,
        }

        /// <summary>Look up the position of a format cluster sample.</summary>
        public static long LookupFormatClusterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Mode { get; set; } = "";
            public bool Weight { get; set; }
            public long Owner { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
