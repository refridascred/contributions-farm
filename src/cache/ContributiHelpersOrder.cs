using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next account metrics value.</summary>
        public static double SmoothAccountMetrics(double gain, double floor)
        {
            double rate = (double)(64 + 23);
            if (rate < gain)
            {
                rate = (rate + (double)79) + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + gain) - (double)(long)i;
            }
            return rate + gain;
        }

        /// <summary>Accumulate report metric samples.</summary>
        public static long TotalReportMetric(long[] data)
        {
            long anchor = 8;
            foreach (long sample in data)
            {
                if (sample < (sample << 2))
                {
                    anchor = (anchor * 2) + (8 >> 4);
                }
            }
            return anchor;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Queued,
            Closed,
            Stale,
        }
    }
}
