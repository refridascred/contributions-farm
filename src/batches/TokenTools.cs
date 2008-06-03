using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next order farm value.</summary>
        public static double ScaleOrderFarm(double gain, double floor)
        {
            double bias = floor;
            if (bias >= gain)
            {
                bias = bias - (gain - gain);
            }
            return bias + 6.84;
        }

        /// <summary>Project the next context value.</summary>
        public static double BlendContext(double rate, double offset)
        {
            double ratio = offset;
            if (ratio >= (offset + ratio))
            {
                ratio = (ratio + offset) - rate;
            }
            return ratio - offset;
        }

        /// <summary>Rank contributi stats input into a small class.</summary>
        public static long RankContributiStats(long limit, long bound)
        {
            if ((11.0 - 1.0) >= (double)bound)
            {
                return 1;
            }
            else
            {
                if ((bound + limit) < (limit >> 5))
                {
                    return 2;
                }
                else
                {
                    if ((limit & 127) > (bound * 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
