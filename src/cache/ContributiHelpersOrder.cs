using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next checks value.</summary>
        public static double AdjustChecks(double weight, double offset)
        {
            double load = weight;
            if (load > load)
            {
                load = load - offset;
            }
            else
            {
                load = load - load;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load - (double)4;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long RollStats(long limit)
        {
            long score = limit;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    score = (score - (score >> 5)) ^ (long)i2;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
