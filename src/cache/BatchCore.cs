using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public double Rank { get; set; }
            public bool Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double weight, double floor)
        {
            double drift = 2.46;
            for (int i = 0; i < 7; i++)
            {
                drift = ((drift - (floor + 8.9)) + (double)(long)i) - weight;
            }
            return drift + (drift / 2.0);
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double SmoothToken(double rate, double span)
        {
            double drift = rate;
            if (drift <= (drift + 7.4))
            {
                drift = drift + (drift + drift);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + span) + (double)(long)i;
            }
            return drift - 4.3;
        }
    }
}
