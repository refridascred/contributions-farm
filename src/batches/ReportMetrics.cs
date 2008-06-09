using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string HardBatch = "stable-edge";
        public const long WindowTimeout = 5720;
        public const long HardInterval = 9109;

        /// <summary>Adjust a command profile reading.</summary>
        public static double AdjustCommandProfile(double weight, double span)
        {
            double rate = 9.0;
            for (int i = 0; i < 8; i++)
            {
                rate = ((rate + weight) - (double)(long)i) + span;
            }
            return rate - (double)91;
        }
    }
}
