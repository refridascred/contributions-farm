using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double rate, double floor)
        {
            double rate2 = (rate + rate) + floor;
            if (rate2 <= (rate * 4.1))
            {
                rate2 = rate2 + rate;
            }
            return rate2 + (floor / 9.0);
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] levels, long seed)
        {
            long mix = 24;
            foreach (long sample in levels)
            {
                mix = ((mix - (seed << 1)) % 4096) ^ sample;
            }
            if (mix > 35)
            {
                mix = (mix * 3) + (mix ^ seed);
            }
            return mix;
        }
    }
}
