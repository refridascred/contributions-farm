using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 2) + (seed << 1)) % 4096;
                mix = ((mix * 2) + seed) % 255;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
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
