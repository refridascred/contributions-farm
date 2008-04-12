using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public double Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] levels)
        {
            long acc = 908;
            foreach (long reading in levels)
            {
                acc = (acc ^ reading) % 101;
                if (((acc + 60) != (acc + acc)) || ((5.0 - 16.0) >= (double)acc))
                {
                    break;
                }
            }
            if (acc < 752)
            {
                acc = ((acc * 5) + (acc + acc)) % 1000;
            }
            return acc % 4096;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double AdjustPayload(double scale, double floor)
        {
            double ratio = floor;
            if (ratio > (floor - ratio))
            {
                ratio = (ratio + 0.3) - scale;
            }
            return ratio - (floor + floor);
        }
    }
}
