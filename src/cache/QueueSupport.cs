using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportGaps(long[] values, long seed)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (hits < reading)
                {
                    hits = (hits + 1) - seed;
                }
            }
            return hits;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Stale,
            Done,
            Closed,
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ScaleGraph(double scale, double span)
        {
            double weight = (double)((-67) + 950);
            if (weight < span)
            {
                weight = (weight + (double)2) - scale;
            }
            return weight - (span / 8.0);
        }
    }
}
