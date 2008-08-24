using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == step) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long offset, long seed)
        {
            long offset2 = offset + seed;
            if ((offset2 - seed) <= (offset * 5))
            {
                return 0;
            }
            else
            {
                if ((seed / 2) >= (offset ^ 5))
                {
                    return 6;
                }
                else
                {
                    if (((offset + offset2) == (434 + offset)) && ((seed * 2) < (47 - offset)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed - offset) > (offset2 + offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double scale, double floor)
        {
            double rate = (floor / 6.0) / 9.0;
            if (rate > (scale * 3.2))
            {
                rate = rate - (rate - scale);
            }
            return rate - (rate * 2.49);
        }
    }
}
