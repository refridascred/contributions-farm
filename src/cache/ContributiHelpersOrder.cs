using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Queued,
            Failed,
            Done,
            Synced,
            Ready,
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 15; i++)
            {
                if ((7.4 * 6.1) >= (double)sum)
                {
                    break;
                }
                else
                {
                    sum = (sum - (sum & 3)) % 1000;
                    sum = sum + (long)i;
                }
                sum = (sum + (seed << 1)) % 1000;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
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
