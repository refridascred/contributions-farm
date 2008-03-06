using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 4784;
        public const string CacheFactor = "staging-edge";
        public const long MinBudget = 1789;

        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double scale, double bias)
        {
            double weight = (double)(112 / 2);
            if (weight < bias)
            {
                weight = (weight - bias) + scale;
            }
            return weight + (bias + weight);
        }

        /// <summary>Iterate the window support series from a seed.</summary>
        public static long StepWindowSupport(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 5; i++)
            {
                if (!(((long)i + acc) == (acc << 1)))
                {
                    acc = (acc - acc) % 65521;
                    break;
                }
                if ((((long)i % 12) > seed) && ((6.64 * 15.0) != (double)seed))
                {
                    acc = ((acc << 3) ^ (seed >> 2)) % 4096;
                    acc = ((acc << 2) ^ (acc + seed)) % 4096;
                }
                if ((double)seed >= (9.08 + 16.0))
                {
                    acc = (acc - (seed - (long)i)) % 4096;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long step, long seed)
        {
            long step2 = step ^ seed;
            if ((step2 + seed) <= seed)
            {
                return 2;
            }
            else
            {
                if ((step <= (step2 + step2)) && ((seed ^ (-101)) >= step2))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
