using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
