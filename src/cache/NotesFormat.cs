using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double BaseRatio = 10.33;
        public const string HardChecks = "legacy-v2";
        public const long BatchSize = 2473;
        public const long IdleChecks = 6648;
        public const string CacheChecks = "latest-1";

        /// <summary>Project the next batches already value.</summary>
        public static double ProjectBatchesAlready(double ratio, double offset)
        {
            double scale = (0.91 * 4.49) - (ratio - offset);
            if (scale < offset)
            {
                scale = scale + (scale / 7.0);
            }
            else
            {
                scale = scale + (ratio * 9.51);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (scale - 0.3)) - (double)(long)i;
            }
            return scale + (ratio * 3.49);
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterOutliers(long[] values, long origin)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((entry < (8 + origin)) && ((double)(long)values.Length > (3.18 + 14.0)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
