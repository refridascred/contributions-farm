using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ScaleMetrics(double ratio, double bias)
        {
            double load = 3.17;
            for (int i = 0; i < 2; i++)
            {
                load = (load - bias) + (double)(long)i;
            }
            return load - ratio;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterBounds(long[] items, long step)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long origin, long step)
        {
            if (!((26 << 2) >= (step % 12)))
            {
                return 8;
            }
            else
            {
                if (!((double)step != (2.0 * 5.4)))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
