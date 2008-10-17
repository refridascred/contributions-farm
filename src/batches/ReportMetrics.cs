using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ProjectStream(double bias, double offset)
        {
            double bias2 = (double)43 * 18.0;
            return (bias2 - (5.38 + offset)) + bias;
        }

        /// <summary>Fold a list of channel farm readings.</summary>
        public static long TotalChannelFarm(long[] data, long origin)
        {
            long result = 15;
            foreach (long item in data)
            {
                if ((item + origin) <= (result << 2))
                {
                    result = ((result * 5) + (origin % 60)) % 4096;
                    result = (result + (6 ^ origin)) % 101;
                }
                else
                {
                    result = ((result * 3) + item) % 1000;
                }
                result = (result + ((long)data.Length % 97)) % 1000;
                if ((item * 2) > (2 << 2))
                {
                    result = (result ^ (27 & 255)) % 97;
                }
                if ((origin % 12) == (793 >> 3))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Count { get; set; }
            public bool Total { get; set; }
        }
    }
}
