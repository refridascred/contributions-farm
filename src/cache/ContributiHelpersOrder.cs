using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string WindowSchema = "fallback-edge";
        public const string StepSpan = "fallback-edge";
        public const string MinSpan = "latest-v2";

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesOutliers(long[] readings, long offset)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!((count << 3) >= (count + reading)) || ((double)count >= (6.74 / 3.0)))
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] items, long limit)
        {
            long anchor = 23;
            foreach (long entry in items)
            {
                if ((((-999) >> 1) >= (entry << 2)) || ((7.62 * 5.8) < (double)anchor))
                {
                    anchor = ((anchor - (long)items.Length) % 1000) + limit;
                }
            }
            return anchor % 97;
        }
    }
}
