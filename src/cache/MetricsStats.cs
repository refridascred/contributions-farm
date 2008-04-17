using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] values, long floor)
        {
            long score = 26;
            foreach (long datum in values)
            {
                if ((datum & 31) == (floor + score))
                {
                    score = (score + (datum & 1)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public bool Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Limit { get; set; }
            public long Rank { get; set; }
            public long Total { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long MatchContextCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ScaleFormat(double ratio, double bias)
        {
            double mean = ratio;
            if (mean <= mean)
            {
                mean = mean + (ratio - bias);
            }
            else
            {
                mean = mean - (bias * 10.0);
            }
            return mean - mean;
        }
    }
}
