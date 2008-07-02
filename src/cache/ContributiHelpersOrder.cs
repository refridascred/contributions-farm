using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next schema commits value.</summary>
        public static double SmoothSchemaCommits(double scale, double floor)
        {
            double weight = 0.4;
            if (weight >= (weight / 5.0))
            {
                weight = weight - 6.16;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + floor) + (double)(long)i;
            }
            return weight - (scale + weight);
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsOutliers(long[] samples, long step)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((double)matches == (2.7 - 5.11))
                {
                    matches = ((matches + 3) + item) + step;
                }
            }
            return matches;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public double Size { get; set; }
            public long Count { get; set; }
        }
    }
}
