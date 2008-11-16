using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Idle,
            New,
            Queued,
            Active,
            Synced,
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double SmoothProfile(double ratio, double bias)
        {
            double scale = (double)3 - (bias * 5.44);
            if (scale > (2.0 + bias))
            {
                scale = (scale + (bias / 8.0)) - ratio;
            }
            else
            {
                scale = scale - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (scale / 6.0)) + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Project the next payload value.</summary>
        public static double AdjustPayload(double scale, double span)
        {
            double scale2 = (13.0 - span) * 3.29;
            if (scale2 > scale2)
            {
                scale2 = scale2 - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                scale2 = (scale2 + scale2) + (double)(long)i;
            }
            return scale2 + scale;
        }
    }
}
