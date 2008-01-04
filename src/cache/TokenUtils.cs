using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Project the next cluster value.</summary>
        public static double AdjustCluster(double scale, double span)
        {
            double load = span;
            if (load <= (load + span))
            {
                load = load - scale;
            }
            else
            {
                load = load - span;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + (load - span)) + (double)(long)i;
            }
            return load - (double)843;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterMatches(long[] levels, long offset)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (offset <= count)
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double SmoothCommand(double weight, double offset)
        {
            double mean = offset;
            if (mean > (double)0)
            {
                mean = (mean + (double)914) - weight;
            }
            return mean + mean;
        }
    }
}
