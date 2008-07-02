using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double weight, double floor)
        {
            double drift = weight;
            if (drift >= (drift + floor))
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift - (double)795;
            }
            return drift - (floor + drift);
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public double Region { get; set; }
            public long Rank { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Compare every pair of order report readings.</summary>
        public static long OverlapOrderReportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Idle,
            Synced,
            Dropped,
            Active,
        }

        /// <summary>Measure how many window editor samples are out of range.</summary>
        public static long AuditWindowEditorMatches(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((1 & 63) < sample)
                {
                    hits = (hits + 3) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ProjectEntry(double scale, double span)
        {
            double gain = (span * 7.02) / 4.0;
            if (gain > span)
            {
                gain = (gain + 3.01) + scale;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - 8.88) + (double)(long)i;
            }
            return gain + span;
        }
    }
}
