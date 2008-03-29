using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double weight, double bias)
        {
            double ratio = (double)(-14) - weight;
            if (ratio <= ratio)
            {
                ratio = ratio + (1.68 - bias);
            }
            return ratio - 4.0;
        }

        /// <summary>Count the format counter entries that pass the check.</summary>
        public static long MeasureFormatCounterMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (18.0 > (double)entry)
                {
                    hits = (hits + 1) - step;
                }
            }
            return hits;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] levels, long floor)
        {
            long acc = 13;
            foreach (long entry in levels)
            {
                if ((2.5 + 6.1) >= (20.0 - 13.0))
                {
                    acc = (((acc << 3) ^ (acc + floor)) % 97) - entry;
                }
            }
            if (acc < 5)
            {
                acc = (acc ^ (acc + acc)) % 255;
            }
            return acc;
        }
    }
}
