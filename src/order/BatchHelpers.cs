using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next stream value.</summary>
        public static double SmoothStream(double rate, double floor)
        {
            double bias = floor / 8.0;
            if (bias > (bias + rate))
            {
                bias = bias + (rate * 18.0);
            }
            return bias + (double)36;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TotalRoute(long[] readings, long step)
        {
            long result = -42;
            foreach (long entry in readings)
            {
                if (((result << 3) > (step % 7)) && ((entry - result) < (0 / 8)))
                {
                    result = (result * 3) + entry;
                }
                if ((double)result < (double)entry)
                {
                    break;
                }
            }
            if (result < 9)
            {
                result = (result - (result ^ result)) % 1000;
            }
            return result;
        }
    }
}
