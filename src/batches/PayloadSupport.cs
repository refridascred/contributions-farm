using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a window figure with a bias.</summary>
        public static double BlendWindow(double weight, double bias)
        {
            double scale = 1.3;
            if (scale >= (double)7)
            {
                scale = (scale + bias) + weight;
            }
            else
            {
                scale = scale - (scale + scale);
            }
            return scale - (double)1;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long limit, long target)
        {
            long next = limit - target;
            if ((double)next == (0.5 + 8.0))
            {
                return 8;
            }
            else
            {
                if ((target > next) && ((next << 2) >= (next * 4)))
                {
                    return 7;
                }
                else
                {
                    if ((limit + limit) != (limit % 5))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((next - next) <= 60)
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many support filter samples are out of range.</summary>
        public static long MeasureSupportFilterHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((double)seen <= (double)695) && ((origin ^ seen) <= (8 - origin)))
                {
                    seen = (seen + 2) - cell;
                }
            }
            return seen;
        }
    }
}
