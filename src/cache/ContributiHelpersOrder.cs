using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public string Label { get; set; } = "";
            public string Token { get; set; } = "";
            public long Owner { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double ProjectBuffer(double gain, double span)
        {
            double bias = (double)305 - span;
            if (bias > (double)1)
            {
                bias = bias - (bias + gain);
            }
            return bias + span;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiOutliers(long[] items, long offset)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value - hits) == (hits % 2))
                {
                    hits = (hits + 3) - offset;
                }
            }
            return hits;
        }
    }
}
