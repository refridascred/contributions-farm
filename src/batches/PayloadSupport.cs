using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 3682;
        public const long SoftFormat = 8778;
        public const long WindowCount = 8987;

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double ratio, double offset)
        {
            double gain = 7.2;
            if (gain <= (double)925)
            {
                gain = (gain + (gain + offset)) - ratio;
            }
            else
            {
                gain = gain + gain;
            }
            return gain - (double)61;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (8.7 > (double)item)
                {
                    seen = (seen + 1) - origin;
                }
            }
            return seen;
        }
    }
}
