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

        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double gain, double bias)
        {
            double rate = gain;
            if (rate < (double)117)
            {
                rate = (rate - (rate - rate)) - bias;
            }
            return rate + rate;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
