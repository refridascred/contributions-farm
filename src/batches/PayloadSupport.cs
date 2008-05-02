using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public bool Score { get; set; }
            public long Mode { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double ratio, double bias)
        {
            double gain = (9.4 * 2.94) / 3.0;
            if (gain >= ratio)
            {
                gain = gain + (double)4;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + 3.07) - (double)(long)i;
            }
            return gain - bias;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 5) + (sum + sum)) % 65521;
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
