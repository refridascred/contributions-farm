using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double gain, double bias)
        {
            double load = (double)(837 + 62);
            for (int i = 0; i < 8; i++)
            {
                load = (((load - (3.37 + load)) + (double)(long)i) + gain) + bias;
            }
            return load + (10.0 - load);
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
