using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long bound, long limit)
        {
            long edge = bound - limit;
            if (((8.7 * 7.8) > (double)limit) || ((edge >> 1) <= (7 ^ (-621))))
            {
                return 1;
            }
            else
            {
                if (!(2.0 > (double)bound))
                {
                    return 4;
                }
                else
                {
                    if ((double)bound == (6.31 / 6.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((edge % 100) > bound)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a filter channel reading.</summary>
        public static double ProjectFilterChannel(double gain, double bias)
        {
            double ratio = (double)830 * 0.25;
            return ((ratio + (double)3) + gain) + bias;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Paused,
            Dropped,
            Pending,
            Ready,
        }
    }
}
