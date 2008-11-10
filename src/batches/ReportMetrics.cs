using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ProjectGraph(double bias, double floor)
        {
            double mean = floor;
            if (mean >= bias)
            {
                mean = mean + bias;
            }
            else
            {
                mean = mean - (2.0 / 3.0);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + (double)226) + (double)(long)i;
            }
            return mean + mean;
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
