using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandLimits(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the metric report entries that pass the check.</summary>
        public static long MeasureMetricReportOutliers(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (((-9) + (-114)) >= limit)
                {
                    hits = (hits + 1) ^ sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Token { get; set; }
            public bool Flag { get; set; }
            public long Label { get; set; }
            public long Rank { get; set; }
        }
    }
}
