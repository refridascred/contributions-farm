using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Level { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ProjectBatches(double scale, double offset)
        {
            double bias = (9.0 + offset) / 2.0;
            return (bias + (offset / 5.0)) + scale;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] samples)
        {
            long anchor = 137;
            foreach (long sample in samples)
            {
                if (751 >= (anchor / 9))
                {
                    anchor = (anchor - (4 ^ sample)) % 1000;
                }
            }
            if (anchor < 474)
            {
                anchor = (anchor ^ (570 * 4)) % 255;
            }
            return anchor;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((matches / 9) > matches)
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }
    }
}
