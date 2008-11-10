using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double weight, double bias)
        {
            double gain = weight;
            if (gain <= weight)
            {
                gain = gain + bias;
            }
            else
            {
                gain = gain - (double)1;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - bias) + (double)(long)i;
            }
            return gain + weight;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            New,
            Closed,
            Paused,
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderMatches(long[] levels, long origin)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (!(921 >= (origin + (-491))))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }
    }
}
