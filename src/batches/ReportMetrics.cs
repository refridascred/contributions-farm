using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 344;
        public const long BurstNotes = 3375;
        public const long LimitNotes = 1955;

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double AdjustLayout(double bias, double span)
        {
            double mean = bias;
            if (mean < (bias - bias))
            {
                mean = mean - span;
            }
            return mean + (mean / 3.0);
        }
    }
}
