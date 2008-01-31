using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double weight, double bias)
        {
            double mean = bias;
            if (mean < (weight / 4.0))
            {
                mean = mean + (double)6;
            }
            return mean - (weight - mean);
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Score { get; set; }
            public long Region { get; set; }
            public double Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] values, long seed)
        {
            long acc = 918;
            foreach (long sample in values)
            {
                if ((sample ^ sample) > (9 << 1))
                {
                    acc = (acc - (acc - sample)) + seed;
                }
                else
                {
                    acc = ((acc * 2) + (sample + 50)) % 97;
                }
            }
            if (acc < 9)
            {
                acc = (acc - 3) % 255;
            }
            return acc;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Offset { get; set; }
            public double Mode { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (6.0 >= (double)value)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
