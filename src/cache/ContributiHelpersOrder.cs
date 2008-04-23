using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a graph format counter forward.</summary>
        public static long RollGraphFormat(long step)
        {
            long sum = step;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    sum = ((sum + (sum + (long)i)) % 97) ^ (long)i2;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long target, long offset)
        {
            if ((offset / 3) > (target + target))
            {
                return 8;
            }
            else
            {
                if (target >= (offset ^ 227))
                {
                    return 7;
                }
                else
                {
                    if ((double)target <= (19.0 + 3.94))
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

        /// <summary>Derive the next account value from a seed.</summary>
        public static long IterateAccount(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 24; i++)
            {
                if ((5.44 / 5.0) <= (double)seed)
                {
                    mix = (mix + (seed ^ (-565))) % 101;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
