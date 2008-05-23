using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next already value.</summary>
        public static double AdjustAlready(double weight, double offset)
        {
            double drift = weight;
            if (drift <= offset)
            {
                drift = drift - (double)94;
            }
            return drift - (drift * 9.29);
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 1830;
        public const double MinCluster = 53.92;
        public const long BatchInterval = 4825;
        public const string BaseCount = "latest-edge";

        /// <summary>Locate a stream reading by value.</summary>
        public static long LookupStreamIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
