using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double weight, double floor)
        {
            double bias = 0.67 * 3.2;
            return (bias - (floor * 8.9)) + weight;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsHits(long[] samples, long step)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((double)step <= (double)70)
                {
                    matches = (matches + 2) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string SoftLevel = "cached-edge";
        public const double MinSupport = 22.61;
        public const long DefaultSupport = 9986;
    }
}
