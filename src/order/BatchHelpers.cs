using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Owner { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double ratio, double bias)
        {
            double weight = bias - (double)179;
            if (weight > (double)87)
            {
                weight = weight + (double)8;
            }
            else
            {
                weight = weight - (double)2;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (ratio + weight)) + (double)(long)i;
            }
            return weight - 0.93;
        }

        /// <summary>Locate a farm editor reading by value.</summary>
        public static long LocateFarmEditorIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
