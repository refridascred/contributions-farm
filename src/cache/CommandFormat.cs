using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiMatches(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((double)matches > 6.0)
                {
                    matches = (matches + 3) - cell;
                }
            }
            return matches;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 7; i++)
            {
                mix = (mix ^ mix) % 65521;
                mix = ((mix * 2) + (floor % 7)) % 255;
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Project the next payload value.</summary>
        public static double AdjustPayload(double weight, double floor)
        {
            double gain = 7.09;
            if (gain < 5.84)
            {
                gain = (gain - (floor / 6.0)) - weight;
            }
            return gain + (double)9;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsMatches(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (entry >= (floor / 5))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
