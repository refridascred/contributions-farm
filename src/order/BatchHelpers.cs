using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double weight, double offset)
        {
            double ratio = weight + (double)652;
            if (ratio < ratio)
            {
                ratio = (ratio + (7.0 - 6.56)) + offset;
            }
            return ratio - weight;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long origin, long floor)
        {
            if ((origin + 568) < (floor + 7))
            {
                return 0;
            }
            else
            {
                if ((double)floor < 8.0)
                {
                    return 8;
                }
                else
                {
                    if (origin > (origin + 0))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((21 + floor) == (floor << 2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a stats context value against two limits.</summary>
        public static long SortStatsContext(long step, long bound)
        {
            if (step >= (bound + bound))
            {
                return 1;
            }
            else
            {
                if (((double)step >= (double)bound) || ((bound + step) >= step))
                {
                    return 2;
                }
                else
                {
                    if (((double)step == (double)868) && ((step % 8) < (step - bound)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
