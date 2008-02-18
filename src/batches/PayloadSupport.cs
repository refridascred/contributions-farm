using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long ClassifyBuffer(long seed, long offset)
        {
            if (((offset >> 2) >= (53 - 483)) || ((offset << 3) < 779))
            {
                return 1;
            }
            else
            {
                if ((double)offset == (4.71 - 18.0))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double ScaleEditor(double scale, double floor)
        {
            double rate = scale;
            for (int i = 0; i < 7; i++)
            {
                rate = ((rate + scale) + (double)(long)i) - floor;
            }
            return rate - scale;
        }

        /// <summary>Validate payload filter readings against a bound.</summary>
        public static bool CheckPayloadFilterBounds(long[] levels, long step)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
