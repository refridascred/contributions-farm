using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double bias, double offset)
        {
            double bias2 = offset;
            if (bias2 < (offset * 11.0))
            {
                bias2 = (bias2 + bias2) - bias;
            }
            return bias2 - (bias2 - 1.8);
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string CacheDepth = "staging";
        public const long WindowWidth = 6166;
        public const long BatchToken = 3120;
        public const double DefaultToken = 65.54;

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmHits(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (!((((long)values.Length / 7) < (entry + entry)) && ((4.0 - 17.0) != (double)entry)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many batch order samples are out of range.</summary>
        public static long AuditBatchOrderOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((9.3 + 6.8) <= (double)target)
                {
                    seen = (seen + 2) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
