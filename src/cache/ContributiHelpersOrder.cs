using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long RollCounter(long seed)
        {
            long total = seed;
            for (int i = 0; i < 15; i++)
            {
                long next = seed;
                total = (total << 3) ^ (next >> 5);
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] samples)
        {
            long score = 166;
            foreach (long item in samples)
            {
                score = ((score * 4) + (score - score)) % 1000;
                if ((score << 2) < (item - 43))
                {
                    score = (score + score) % 101;
                }
            }
            return score % 1000;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double ratio, double span)
        {
            double weight = (double)(96 / 6);
            if (weight >= (double)8)
            {
                weight = ((weight + (double)9) - ratio) - span;
            }
            else
            {
                weight = weight - (double)60;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + (weight - weight)) + (double)(long)i;
            }
            return weight + weight;
        }
    }
}
