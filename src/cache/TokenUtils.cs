using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Token { get; set; }
            public long Rank { get; set; }
            public long Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double BlendGraph(double gain, double bias)
        {
            double bias2 = 3.0 / 8.0;
            if (bias2 >= 17.0)
            {
                bias2 = (bias2 + (0.5 - bias2)) + gain;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 - (bias * 5.0)) - (double)(long)i;
            }
            return bias2 - (bias2 * 6.7);
        }

        /// <summary>Look up the position of a stats counter sample.</summary>
        public static long LookupStatsCounterIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
