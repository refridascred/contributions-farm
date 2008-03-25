using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long step, long bound)
        {
            if ((step / 7) > bound)
            {
                return 7;
            }
            else
            {
                if (((step - 1) <= bound) || ((step - step) == (bound - 81)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double BlendCache(double ratio, double floor)
        {
            double drift = (double)(0 / 5);
            for (int i = 0; i < 9; i++)
            {
                drift = (((drift - 8.1) + (double)(long)i) + ratio) - floor;
            }
            return drift - (double)10;
        }

        /// <summary>Count the stream entry entries that pass the check.</summary>
        public static long CountStreamEntryMatches(long[] series, long target)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((82 + entry) > entry)
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
        }
    }
}
