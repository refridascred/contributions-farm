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

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long limit, long step)
        {
            if ((limit - limit) <= (51 >> 3))
            {
                return 4;
            }
            else
            {
                if ((limit - limit) == (1 >> 2))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
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
