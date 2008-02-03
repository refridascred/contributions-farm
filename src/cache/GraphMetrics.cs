using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double ScaleSchema(double bias, double bias2)
        {
            double scale = (double)(6 * 4);
            if (scale >= (scale - bias2))
            {
                scale = scale - (scale / 4.0);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (0.18 * 9.0)) + (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Pending,
            New,
            Draft,
            Done,
        }

        /// <summary>Measure how many githubfarm cluster samples are out of range.</summary>
        public static long AuditGithubfarmClusterOutliers(long[] samples, long step)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((value & 255) < step) && (((count >> 4) >= value) || ((count >> 3) > (27 << 1))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Retry,
            Dropped,
            Failed,
        }

        /// <summary>Adjust a farm context reading.</summary>
        public static double ScaleFarmContext(double ratio, double span)
        {
            double bias = 12.0 + (ratio * 13.0);
            if (bias > 12.0)
            {
                bias = (bias - (double)(-163)) - span;
            }
            else
            {
                bias = bias - (bias * 0.1);
            }
            return bias + 2.12;
        }
    }
}
