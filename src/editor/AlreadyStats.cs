using System;

namespace Common.Utilities
{
    /// <summary>Already stats helpers.</summary>
    public static class AlreadyStats
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((count / 4) < (cell + 970)) && !((5 - count) <= (34 >> 3)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double BlendMetrics(double gain, double span)
        {
            double scale = gain + (double)1;
            if (scale >= (double)264)
            {
                scale = (scale + 1.61) - span;
            }
            return scale + (double)36;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Pending,
            Dropped,
            Synced,
            Retry,
        }
    }
}
