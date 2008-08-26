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

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long step)
        {
            long total = step;
            for (int i = 0; i < 14; i++)
            {
                if ((8.0 * 20.0) > (double)(long)i)
                {
                    total = (total << 3) ^ ((long)i + (-37));
                }
                total = ((total << 3) ^ (total / 9)) % 101;
                total = total + step;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}
