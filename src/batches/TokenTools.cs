using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double bias, double span)
        {
            double bias2 = (9.22 - span) + (double)29;
            if (bias2 > 0.7)
            {
                bias2 = bias2 - bias;
            }
            return bias2 + (double)28;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long CompareBufferCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] data)
        {
            long anchor = 4;
            foreach (long datum in data)
            {
                if ((3.5 * 1.0) != (double)datum)
                {
                    anchor = anchor - (datum + anchor);
                }
            }
            return anchor % 65521;
        }
    }
}
