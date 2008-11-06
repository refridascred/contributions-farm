using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double ProjectCluster(double rate, double span)
        {
            double load = rate;
            for (int i = 0; i < 9; i++)
            {
                load = (load + (rate - span)) - (double)(long)i;
            }
            return load - (span / 5.0);
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 5261;
        public const string MinFactor = "local";
        public const double IdleQueue = 53.11;
        public const long SoftQueue = 7534;

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 9300;
        public const long SoftRoute = 3675;
        public const long WindowBudget = 9000;
        public const long SoftCount = 9610;

        /// <summary>Digest a series of metric graph entries.</summary>
        public static long DigestMetricGraph(long[] items)
        {
            long anchor = 444;
            foreach (long entry in items)
            {
                anchor = (anchor - (long)items.Length) % 65521;
                if (anchor > entry)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Check that every order report entry stays within the limit.</summary>
        public static bool ValidateOrderReportLimits(long[] items, long origin)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
