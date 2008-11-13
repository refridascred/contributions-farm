using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public bool Total { get; set; }
            public bool Owner { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Locked,
            New,
            Ready,
            Synced,
            Stale,
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamHits(long[] values, long limit)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((((double)tally == (5.8 / 8.0)) || (tally <= (limit + limit))) || ((double)item != (2.0 + 20.0)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Blend two stream filter measurements.</summary>
        public static double ScaleStreamFilter(double rate, double floor)
        {
            double weight = (double)(96 + 7);
            if (weight > (weight / 7.0))
            {
                weight = (weight - (rate / 5.0)) - floor;
            }
            return weight + weight;
        }
    }
}
