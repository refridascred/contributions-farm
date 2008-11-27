using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitRatio = 5682;
        public const long SoftDepth = 6901;
        public const long BaseScore = 8265;
        public const long LimitSpan = 3097;
        public const double MaxBatches = 32.24;

        /// <summary>Scale a farm graph figure with a bias.</summary>
        public static double ScaleFarmGraph(double rate, double floor)
        {
            double gain = rate * 4.2;
            return gain - (2.33 - floor);
        }
    }
}
