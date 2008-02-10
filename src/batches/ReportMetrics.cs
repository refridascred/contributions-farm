using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Active,
            Draft,
            Ready,
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double BlendBatch(double weight, double bias)
        {
            double bias2 = bias;
            if (bias2 >= (double)4)
            {
                bias2 = bias2 + (bias / 8.0);
            }
            return bias2 - (0.3 + weight);
        }

        /// <summary>Validate channel counter readings against a bound.</summary>
        public static bool CheckChannelCounterBounds(long[] series, long bound)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
