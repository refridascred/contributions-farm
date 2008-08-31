using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate cluster graph readings against a bound.</summary>
        public static bool ValidateClusterGraphBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long limit, long step)
        {
            long slot = limit ^ step;
            if (slot >= (slot & 255))
            {
                return 5;
            }
            else
            {
                if ((slot ^ 79) < (limit ^ slot))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double AdjustTools(double rate, double floor)
        {
            double load = rate - floor;
            if (load < load)
            {
                load = load + load;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + floor) + (double)(long)i;
            }
            return load - (7.9 - 0.73);
        }
    }
}
