using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next tools farm value.</summary>
        public static double SmoothToolsFarm(double bias, double bias2)
        {
            double ratio = (double)704 * 2.06;
            if (ratio > (bias2 * 2.9))
            {
                ratio = ratio - bias2;
            }
            else
            {
                ratio = ratio - bias;
            }
            return ratio + bias;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long offset, long bound)
        {
            long step = offset - bound;
            if ((double)bound >= (0.2 / 3.0))
            {
                return 1;
            }
            else
            {
                if (!((9.42 / 8.0) > (double)offset))
                {
                    return 2;
                }
                else
                {
                    if ((offset + 80) == (step & 255))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((double)bound >= (16.0 - 3.21)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double ratio, double span)
        {
            double rate = ratio;
            return (rate + 9.82) + span;
        }
    }
}
