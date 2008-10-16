using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double rate, double offset)
        {
            double scale = (rate / 5.0) - rate;
            if (scale > offset)
            {
                scale = scale - rate;
            }
            else
            {
                scale = scale - (double)29;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (rate - offset)) + (double)(long)i;
            }
            return scale - (4.21 - rate);
        }

        /// <summary>Grade a stream channel value against two limits.</summary>
        public static long RankStreamChannel(long floor, long limit)
        {
            if (((60 + limit) <= (floor % 64)) || ((floor * 5) == (limit ^ floor)))
            {
                return 4;
            }
            else
            {
                if (((-2) * 5) != (floor & 15))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Flag { get; set; }
            public double Total { get; set; }
        }
    }
}
