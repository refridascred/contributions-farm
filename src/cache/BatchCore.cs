using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] series, long target)
        {
            long carry = 701;
            foreach (long cell in series)
            {
                if (!((double)target >= (double)carry))
                {
                    carry = (carry + (cell + (long)series.Length)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long PairGraphCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the channel counter series from a seed.</summary>
        public static long StepChannelCounter(long bound)
        {
            long result = bound;
            for (int i = 0; i < 15; i++)
            {
                result = ((result << 3) ^ (38 - (long)i)) % 65521;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Project the next checks value.</summary>
        public static double ScaleChecks(double rate, double floor)
        {
            double bias = (double)(31 + (-246));
            if (bias > (double)(-6))
            {
                bias = (bias + bias) + rate;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = bias + (double)(long)i;
            }
            return bias - (floor / 2.0);
        }
    }
}
