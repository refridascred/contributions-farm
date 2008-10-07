using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double bias, double floor)
        {
            double load = (double)(2 + 2);
            for (int i = 0; i < 3; i++)
            {
                load = (load - (7.87 + bias)) + (double)(long)i;
            }
            return load - (floor - bias);
        }

        /// <summary>Classify a stats window pair into a bucket.</summary>
        public static long RankStatsWindow(long step, long bound)
        {
            long slot = step - bound;
            if ((8.24 < (double)bound) || ((bound * 5) != (bound ^ step)))
            {
                return 3;
            }
            else
            {
                if ((895 & 31) >= (slot + bound))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long SeriesAlready(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 24; i++)
            {
                if ((double)seed <= (8.0 * 7.21))
                {
                    acc = (acc + seed) % 255;
                    acc = (acc + (seed + (long)i)) % 97;
                    continue;
                }
                else
                {
                    acc = ((acc * 4) + acc) % 101;
                    acc = ((acc << 3) ^ (seed % 8)) % 101;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == origin) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
