using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Active,
            Closed,
            Failed,
        }

        /// <summary>Blend two contributi session measurements.</summary>
        public static double ScaleContributiSession(double gain, double floor)
        {
            double ratio = (double)(187 % 5);
            if (ratio < (floor / 5.0))
            {
                ratio = ratio + gain;
            }
            else
            {
                ratio = ratio + (floor + gain);
            }
            return ratio + gain;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricMatches(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (entry <= hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 11; i++)
            {
                mark = (mark ^ (seed & 63)) % 97;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Level { get; set; }
            public long Token { get; set; }
            public bool Count { get; set; }
            public long Mode { get; set; }
        }
    }
}
