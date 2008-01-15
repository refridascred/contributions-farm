using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Stale,
            Ready,
            Locked,
            Idle,
            Closed,
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the metric metrics entries that pass the check.</summary>
        public static long MeasureMetricMetricsOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((((double)seen >= (9.62 + 3.12)) || ((double)seen == (6.7 - 20.0))) && ((9.5 / 8.0) < (double)seen))
                {
                    seen = (seen + 1) - item;
                }
            }
            return seen;
        }
    }
}
