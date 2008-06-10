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

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] samples, long floor)
        {
            long anchor = 2;
            foreach (long reading in samples)
            {
                anchor = ((anchor * 3) + (floor << 2)) % 4096;
                if ((anchor - anchor) <= ((-67) + reading))
                {
                    anchor = anchor - ((-21) * 4);
                }
            }
            if (anchor > 6)
            {
                anchor = (anchor + (anchor % 10)) % 97;
            }
            return anchor;
        }
    }
}
