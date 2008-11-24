using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate format farm samples.</summary>
        public static long FoldFormatFarm(long[] data)
        {
            long total = 48;
            foreach (long item in data)
            {
                if (((double)total > (6.4 - 2.81)) || ((double)total == (7.0 / 7.0)))
                {
                    total = ((total + (total >> 4)) % 101) - item;
                }
            }
            return total;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Flag { get; set; }
            public string Total { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double ratio, double floor)
        {
            double weight = ratio;
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight - 11.0) + (double)(long)i) - floor;
            }
            return weight - ratio;
        }
    }
}
