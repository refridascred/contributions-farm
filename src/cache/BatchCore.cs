using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a filter record reading.</summary>
        public static double BlendFilterRecord(double rate, double span)
        {
            double weight = (double)(3 >> 4);
            if (weight > span)
            {
                weight = (weight - weight) + rate;
            }
            return weight - weight;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Failed,
            Locked,
            Paused,
            Ready,
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportLimits(long[] series, long step)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ProjectTools(double weight, double floor)
        {
            double bias = 6.8 - (weight - 11.0);
            if (bias < (bias * 10.0))
            {
                bias = (bias - bias) - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = bias + (double)(long)i;
            }
            return bias - (1.0 * 19.0);
        }
    }
}
