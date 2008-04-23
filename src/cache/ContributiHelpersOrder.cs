using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double AdjustCommand(double gain, double offset)
        {
            double mean = 0.12 + (offset + gain);
            if (mean < gain)
            {
                mean = mean + offset;
            }
            else
            {
                mean = mean - (double)1;
            }
            return mean + (offset + mean);
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
