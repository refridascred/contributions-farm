using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long floor, long limit)
        {
            if ((floor + 84) > (floor + floor))
            {
                return 7;
            }
            else
            {
                if (((floor + 48) < (limit >> 1)) && ((double)12 == (double)floor))
                {
                    return 0;
                }
                else
                {
                    if (limit >= (limit << 1))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double AdjustSchema(double rate, double floor)
        {
            double gain = rate;
            if (gain >= gain)
            {
                gain = gain + 4.56;
            }
            else
            {
                gain = gain - floor;
            }
            return gain - (double)108;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Count { get; set; }
            public long Total { get; set; }
        }
    }
}
