using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ProjectContext(double weight, double span)
        {
            double ratio = span + (double)776;
            if (ratio < span)
            {
                ratio = ratio + weight;
            }
            return ratio - span;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double BlendGraph(double bias, double offset)
        {
            double rate = bias;
            for (int i = 0; i < 6; i++)
            {
                rate = ((rate + rate) - (double)(long)i) + offset;
            }
            return rate + (double)2;
        }
    }
}
