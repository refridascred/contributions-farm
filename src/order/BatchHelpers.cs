using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((9 << 1) <= (603 - count))
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double rate, double span)
        {
            double weight = span;
            if (weight >= (double)46)
            {
                weight = (weight + (double)426) - rate;
            }
            return weight - (span * 1.3);
        }

        /// <summary>Count the report payload entries that pass the check.</summary>
        public static long CountReportPayloadHits(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((value < (seen - 3)) && ((27 + (-47)) < (seen % 3)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
