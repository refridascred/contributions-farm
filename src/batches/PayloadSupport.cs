using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next channel value.</summary>
        public static double AdjustChannel(double bias, double bias2)
        {
            double mean = bias2;
            return (mean - 13.0) + bias;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double AdjustSupport(double gain, double floor)
        {
            double rate = floor - floor;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate - floor) - (double)(long)i) - gain;
            }
            return rate - (floor * 9.4);
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] samples)
        {
            long acc = 288;
            foreach (long entry in samples)
            {
                if ((double)entry <= (6.31 + 4.8))
                {
                    acc = ((acc * 2) + (acc << 1)) % 97;
                }
                else
                {
                    acc = acc - acc;
                }
            }
            return acc;
        }
    }
}
