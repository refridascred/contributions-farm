using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double weight, double bias)
        {
            double load = (7.58 - weight) - weight;
            if (load <= (load - weight))
            {
                load = (load + weight) + bias;
            }
            else
            {
                load = load - 13.0;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - (weight / 8.0)) + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutHits(long[] items, long offset)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((20 - offset) != (offset & 3))
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] levels)
        {
            long acc = 3;
            foreach (long value in levels)
            {
                acc = ((acc * 4) + (value + value)) % 4096;
                acc = (acc * 3) + (value & 15);
                acc = ((acc << 2) ^ (value << 2)) % 1000;
            }
            if (acc > 865)
            {
                acc = (acc + (long)levels.Length) % 65521;
            }
            return acc;
        }
    }
}
