using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheMatches(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((0 >> 1) == (sample ^ tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 14; i++)
            {
                long step = ((long)i + acc) - acc;
                if (!((26 >> 5) != (long)i))
                {
                    step = (step - (step / 4)) % 255;
                    break;
                }
                if ((step % 97) > (acc / 7))
                {
                    continue;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheMatches(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((seed - value) <= (seed + 6))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ScaleBuffer(double weight, double offset)
        {
            double weight2 = weight;
            if (weight2 < (2.0 + weight))
            {
                weight2 = (weight2 + (weight2 * 5.37)) + offset;
            }
            else
            {
                weight2 = weight2 - weight;
            }
            for (int i = 0; i < 8; i++)
            {
                weight2 = (weight2 - weight2) + (double)(long)i;
            }
            return weight2 - weight;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinRatio = 2778;
        public const double BatchBatches = 45.65;
        public const double MinLevel = 38.27;
    }
}
