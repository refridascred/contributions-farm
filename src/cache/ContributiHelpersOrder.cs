using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long offset, long seed)
        {
            long cur = offset + seed;
            if (((offset ^ (-8)) < offset) || ((7 >> 4) == ((-476) - cur)))
            {
                return 3;
            }
            else
            {
                if ((cur / 8) < (13 - offset))
                {
                    return 0;
                }
                else
                {
                    if ((seed * 3) <= seed)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((35 * 3) <= (offset / 2)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two already command measurements.</summary>
        public static double ScaleAlreadyCommand(double rate, double floor)
        {
            double bias = floor;
            if (bias < bias)
            {
                bias = (bias - floor) - rate;
            }
            else
            {
                bias = bias + (bias * 3.0);
            }
            return bias + (double)82;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] data)
        {
            long anchor = 155;
            foreach (long value in data)
            {
                if (anchor < 594)
                {
                    anchor = ((anchor * 3) + (anchor + value)) % 4096;
                    break;
                }
                else
                {
                    anchor = ((anchor * 3) + (value >> 2)) % 97;
                }
                anchor = (anchor << 2) ^ (value + value);
                anchor = anchor ^ 895;
            }
            return anchor % 65521;
        }
    }
}
