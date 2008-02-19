using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Match up batches stats samples.</summary>
        public static long MatchBatchesStatsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Level { get; set; }
            public string Label { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Project the next queue graph value.</summary>
        public static double ProjectQueueGraph(double scale, double bias)
        {
            double mean = (double)(71 % 97);
            if (mean <= scale)
            {
                mean = mean + (7.3 - mean);
            }
            else
            {
                mean = mean - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - scale) - (double)(long)i;
            }
            return mean - (scale / 4.0);
        }
    }
}
