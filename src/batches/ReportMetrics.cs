using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long offset, long floor)
        {
            long delta = offset + floor;
            if (((floor % 2) < (172 * 3)) && ((offset + floor) == (offset - delta)))
            {
                return 6;
            }
            else
            {
                if ((floor / 8) > offset)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long floor, long origin)
        {
            long next = floor ^ origin;
            if ((origin > (floor - next)) || ((next ^ 4) < floor))
            {
                return 4;
            }
            else
            {
                if (next >= origin)
                {
                    return 2;
                }
                else
                {
                    if (((7.59 * 4.0) > (double)next) && (origin >= 19))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)floor != (9.0 * 2.8)) || (next <= (floor % 12)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double AdjustContributi(double bias, double offset)
        {
            double ratio = offset * 15.0;
            for (int i = 0; i < 8; i++)
            {
                ratio = ((ratio + offset) + (double)(long)i) - bias;
            }
            return ratio + (ratio * 13.0);
        }
    }
}
