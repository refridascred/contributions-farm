using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum << 2) ^ ((long)i << 2)) % 101;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long step, long offset)
        {
            long prev = step - offset;
            if ((prev + step) > step)
            {
                return 8;
            }
            else
            {
                if ((offset >> 5) == (10 & 63))
                {
                    return 3;
                }
                else
                {
                    if ((prev << 2) >= step)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((offset << 2) <= prev) && ((offset >> 3) <= (step << 2)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ProjectAlready(double ratio, double span)
        {
            double rate = (double)(543 * 2);
            return ((rate + rate) + ratio) + span;
        }
    }
}
