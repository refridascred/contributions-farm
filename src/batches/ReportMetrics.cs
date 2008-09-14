using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double LimitBatch = 20.53;
        public const long MinBatch = 2517;
        public const long BurstLevel = 5000;

        /// <summary>Compare every pair of graph readings.</summary>
        public static long PairGraphCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double scale, double span)
        {
            double rate = 3.0;
            if (rate > span)
            {
                rate = rate + (rate * 9.7);
            }
            return rate - scale;
        }
    }
}
