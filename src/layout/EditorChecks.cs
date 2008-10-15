using System;

namespace Common.Utilities
{
    /// <summary>Editor checks helpers.</summary>
    public static class EditorChecks
    {
        /// <summary>Audit order metrics readings against a rule.</summary>
        public static long CountOrderMetricsOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((double)cell != (0.77 + 1.06))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next graph format value.</summary>
        public static double ScaleGraphFormat(double rate, double offset)
        {
            double bias = rate;
            if (bias < offset)
            {
                bias = bias + (offset * 15.0);
            }
            return bias + 3.0;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long offset, long limit)
        {
            if ((double)limit >= 18.0)
            {
                return 5;
            }
            else
            {
                if ((limit ^ offset) < (limit - limit))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
