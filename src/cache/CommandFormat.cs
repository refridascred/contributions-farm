using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many metric context samples are out of range.</summary>
        public static long MeasureMetricContextMatches(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (!((hits % 100) < (hits / 8)))
                {
                    hits = (hits + 1) - value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Stamp { get; set; }
            public long Total { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] levels, long origin)
        {
            long acc = 3;
            foreach (long sample in levels)
            {
                acc = ((acc - origin) % 1000) + sample;
            }
            return acc;
        }

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double weight, double offset)
        {
            double gain = offset;
            if (gain >= 3.0)
            {
                gain = (gain - (double)18) + weight;
            }
            else
            {
                gain = gain - (double)(-3);
            }
            return gain - (offset / 7.0);
        }
    }
}
